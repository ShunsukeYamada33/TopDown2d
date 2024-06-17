using UnityEngine;
using VContainer;

public class UseTimer
{
    private readonly ITimer _timer;
    private readonly ITimerComponent _timerComponent;

    // ��MonoBehaviour �N���X�̏ꍇ�̓R���X�g���N�^��[Inject]��t����
    // ��{�� private readonly �ȃt�B�[���h�ɐݒ�
    [Inject]
    public UseTimer(ITimer timer, ITimerComponent timerComponent)
    {
        _timer = timer;
        _timerComponent = timerComponent;
    }
}
