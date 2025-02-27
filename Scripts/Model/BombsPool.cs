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
            CreateBomb, // 生成
            GetBomb,    // 再利用
            ReleaseBomb // 返却
            );

        _explosionPool = new ObjectPool<ExplosionObject>(
            CreateExplosion, // 生成
            GetExplosion,    // 再利用
            ReleaseExplosion // 返却
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
            // 3秒後に実行
            .Timer(TimeSpan.FromSeconds(3.0f))
            .Subscribe(_ =>
            {
                // 爆弾を返却
                _bombsPool.Release(bomb);
                // 爆発を取得
                var explosion = _explosionPool.Get();
                // 爆発の位置を爆弾と同じに
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
