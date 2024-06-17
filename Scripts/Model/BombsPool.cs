using R3;
using System;
using UnityEngine;
using UnityEngine.Pool;

public class BombsPool : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private BombObject bombPrefab;
    [SerializeField] private ExplosionObject explosionPrefab;
    private ObjectPool<BombObject> _bombsPool;
    private ObjectPool<ExplosionObject> _explosionPool;

    private void Awake()
    {
        _transform = transform;
        
        _bombsPool = new ObjectPool<BombObject>(
            CreateBomb, // ����
            GetBomb,    // �ė��p
            ReleaseBomb // �ԋp
            );

        _explosionPool = new ObjectPool<ExplosionObject>(
            CreateExplosion, // ����
            GetExplosion,    // �ė��p
            ReleaseExplosion // �ԋp
            );
    }

    public void PlaceBomb(Vector3 position, int firePower)
    {
        var bomb = _bombsPool.Get();
        bomb.transform.position = position;
        bomb.firePower = firePower;
    }

    private BombObject CreateBomb()
    {
        return Instantiate(bombPrefab, _transform);
    }

    private void GetBomb(BombObject bomb)
    {
        bomb.gameObject.SetActive(true);
        bomb.boxCollider2D.isTrigger = true;
        Observable
            // 3�b��Ɏ��s
            .Timer(TimeSpan.FromSeconds(3.0f))
            .Subscribe(_ =>
            {
                // ���e��ԋp
                _bombsPool.Release(bomb);
                // �������擾
                var explosion = _explosionPool.Get();
                // �����̈ʒu�𔚒e�Ɠ�����
                explosion.transform.position = bomb.transform.position;
                var firePower = bomb.firePower * 1.5f;
                explosion.transform.localScale = new Vector3(firePower, firePower, 1.0f);
            })
            .AddTo(bomb.gameObject);
    }

    private void ReleaseBomb(BombObject bomb)
    {
        bomb.gameObject.SetActive(false);
    }

    private ExplosionObject CreateExplosion()
    {
        var explosion = Instantiate(explosionPrefab, _transform);
        explosion.OnExplosionEnd
            .Subscribe(_ => _explosionPool.Release(explosion))
            .AddTo(explosion.gameObject);
        return explosion;
    }

    private void GetExplosion(ExplosionObject explosionPrefab)
    {
        explosionPrefab.gameObject.SetActive(true);
    }

    private void ReleaseExplosion(ExplosionObject explosionPrefab)
    {
        explosionPrefab.gameObject.SetActive(false);
    }
}
