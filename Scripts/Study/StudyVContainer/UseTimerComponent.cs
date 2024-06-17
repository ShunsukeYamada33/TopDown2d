using UnityEngine;
using VContainer;

public class UseTimerComponent : MonoBehaviour
{
    private ITimer _timer;
    private ITimerComponent _timerComponent;

    // MonoBehaviour クラスの場合は何か 任意の名前に[Inject]を付ける
    // 基本は private なフィールドに設定
    // Unity Editor での設定も必要。開発者曰く、ゲームオブジェクトは生成と破棄が複雑なので登録されるのは非推奨
    [Inject]
    public void Construct(ITimer timer, ITimerComponent timerComponent)
    {
        _timer = timer;
        _timerComponent = timerComponent;
    }
}
