using R3;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
    // MVP

    // リアクティブプログラミングの総集編
    // 値の変更などをUIに自動で通知することでキャラクターとUIをシンプルに実装する

    // Model     キャラクターなど
    // View      UI
    // Presenter Model と View の中間で紐づける


    private readonly ReactiveProperty<int> _health = new(100);
    public ReadOnlyReactiveProperty<int> Health => _health;

    private readonly Subject<Unit> _onDead = new();
    public Observable<Unit> OnDead => _onDead;


    public void TakeDamage(int damage)
    {
        _health.Value -= damage;
        if (_health.Value <= 0)
        {
            _onDead.OnNext(Unit.Default);
        }
    }
}
