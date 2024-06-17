using UnityEngine;
using VContainer;

public class UseTimerComponent : MonoBehaviour
{
    private ITimer _timer;
    private ITimerComponent _timerComponent;

    // MonoBehaviour �N���X�̏ꍇ�͉��� �C�ӂ̖��O��[Inject]��t����
    // ��{�� private �ȃt�B�[���h�ɐݒ�
    // Unity Editor �ł̐ݒ���K�v�B�J���ҞH���A�Q�[���I�u�W�F�N�g�͐����Ɣj�������G�Ȃ̂œo�^�����͔̂񐄏�
    [Inject]
    public void Construct(ITimer timer, ITimerComponent timerComponent)
    {
        _timer = timer;
        _timerComponent = timerComponent;
    }
}
