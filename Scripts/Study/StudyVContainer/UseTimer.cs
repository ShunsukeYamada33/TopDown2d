using UnityEngine;
using VContainer;

public class UseTimer
{
    private readonly ITimer _timer;
    private readonly ITimerComponent _timerComponent;

    // 非MonoBehaviour クラスの場合はコンストラクタに[Inject]を付ける
    // 基本は private readonly なフィールドに設定
    [Inject]
    public UseTimer(ITimer timer, ITimerComponent timerComponent)
    {
        _timer = timer;
        _timerComponent = timerComponent;
    }
}
