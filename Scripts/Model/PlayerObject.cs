using Cysharp.Threading.Tasks;
using DG.Tweening;
using R3;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerObject : MonoBehaviour
{
    [SerializeField] private PlayerInput input;

    private Transform _transform;
    private float _speed = 5.0f;
    private Vector3 _direction;
    private Animator _animator;

    public int health = 1;
    public int firePower = 1;
    public int bombMax = 1;
    public int speed = 1;

    public Subject<Unit> OnVanish = new();

    public ReactiveProperty<int> experience = new(0);
    public ReactiveProperty<int> level = new(1);

    public List<RewardScriptable> rewardList = new();
    public Subject<List<RewardScriptable>> selectableRewardSubject = new();
    // 取得したリワードとその数
    public Dictionary<RewardScriptable, int> getRewardDictionary = new();

    [SerializeField] private BombsPool bombPool;
    [SerializeField] private MapManager mapManager;

    // ハッシュ値をキャッシュ 軽量化のため
    private static readonly int XHash = Animator.StringToHash("X");
    private static readonly int YHash = Animator.StringToHash("Y");
    private static readonly int SpeedHash = Animator.StringToHash("Speed");
    private static readonly int HitHash = Animator.StringToHash("Hit");
    private static readonly int VanishHash = Animator.StringToHash("Vanish");

    private void Awake()
    {
        _transform = transform;
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        mapManager.GenerateDestroyableWalls(_transform.position);
    }

    private void OnEnable()
    {
        input.actions["Move"].performed += ChangeDirection;
        input.actions["Move"].canceled += ChangeDirection;
        input.actions["Attack"].performed += OnAttack;
    }

    private void OnDisable()
    {
        input.actions["Move"].performed -= ChangeDirection;
        input.actions["Move"].canceled -= ChangeDirection;
        input.actions["Attack"].performed -= OnAttack;
    }

    private void Update()
    {
        // 自分自身の現在の位置
        var position = _transform.position;
        // 移動距離
        var distance = _speed * Time.deltaTime;

        _transform.position = position + distance * _direction;
    }

    private void ChangeDirection(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<Vector2>().normalized;
        _direction = direction;

        _animator.SetFloat(SpeedHash, direction.magnitude);
        if (direction != Vector2.zero)
        {
            _animator.SetFloat(XHash, direction.x);
            _animator.SetFloat(YHash, direction.y);
            
            if(direction.x <= 0.0f)
            {
                _transform.localScale = Vector3.one;
            }
            else
            {
                _transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            }

            // _transform.localScale = direction.x <= 0.0f ? Vector3.one : new Vector3(-1.0f, 1.0f, 1.0f);
        }
    }

    private void OnAttack(InputAction.CallbackContext context)
    {
        SoundManager.Instance.Attack();
        
        // プレイヤーが乗っているタイルの位置を取得
        var tilePosition = mapManager.backGroundTileMap.WorldToCell(_transform.position);
        // タイルの位置の正確な中央の座標を取得
        var tileCenter = mapManager.backGroundTileMap.GetCellCenterWorld(tilePosition);

        bombPool.PlaceBomb(tileCenter, firePower + 1);
    }

    private async UniTaskVoid GetExperience(Collider2D collision)
    {
        // 経験値オブジェクトの重複取得を防ぐ
        collision.tag = "Untagged";

        // await 終わるまで待機する。
        await collision.transform
            .DOJump(_transform.position, 1.0f, 1, 1.0f)
            .SetLink(collision.gameObject)
            .AsyncWaitForCompletion(); // このアニメーションが終わったことを通知

        experience.Value++;
        if(experience.Value >= level.Value)
        {
            experience.Value -= level.Value;
            level.Value++;
            GetReward();
        }

        Destroy(collision.gameObject);
    }

    private void GetReward()
    {
        // 時を止める
        Time.timeScale = 0.0f;

        // ランダムに３つリワード選択肢に送る
        var random = new System.Random();
        var randomReward3 = rewardList
            // 取得していないリワードか既に最大まで取得していないリワードを取得
            .Where(reward => !getRewardDictionary.ContainsKey(reward) || getRewardDictionary[reward] < reward.maxCount)
            // ランダムに並び替える
            .OrderBy(_ => random.Next())
            // 最初から数えて3つ取得
            .Take(3)
            // リストに変換
            .ToList();

        selectableRewardSubject.OnNext(randomReward3);
    }

    public void GetReward(RewardScriptable reward)
    {
        // リワードの効果を適応
        reward.ApplyEffect(this);

        // リワード取得
        // TryAdd は追加に成功した場合は true を返す
        if(!getRewardDictionary.TryAdd(reward, 1))
        {
            // 既にリワードがある場合
            getRewardDictionary[reward]++;
        }

        // そして時は動き出す
        Time.timeScale = 1.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Experience"))
        {
            GetExperience(collision).Forget();
            return;
        }

        var explosion = collision.GetComponent<ExplosionObject>();
        var enemy = collision.GetComponent<EnemyObject>();
        if (explosion != null || enemy != null)
        {
            health--;
            // health -= 1;
            // health = health - 1;

            if(health <= 0)
            {
                _animator.SetTrigger(VanishHash);
            }
            else
            {
                _animator.SetTrigger(HitHash);
            }
            // _animator.SetTrigger(health <= 0 ? VanishHash : HitHash);
        }
    }

    public void VanishEnd()
    {
        Time.timeScale = 0.0f;
        OnVanish.OnNext(Unit.Default);
    }
}
