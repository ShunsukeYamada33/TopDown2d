using R3;
using UnityEngine;

public class CharacterModel : MonoBehaviour
{
    // MVP

    // ���A�N�e�B�u�v���O���~���O�̑��W��
    // �l�̕ύX�Ȃǂ�UI�Ɏ����Œʒm���邱�ƂŃL�����N�^�[��UI���V���v���Ɏ�������

    // Model     �L�����N�^�[�Ȃ�
    // View      UI
    // Presenter Model �� View �̒��ԂŕR�Â���


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
