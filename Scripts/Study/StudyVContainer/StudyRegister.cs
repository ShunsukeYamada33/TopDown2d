using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyRegister : LifetimeScope
{
    // Register
    // 基本的な登録方法

    [SerializeField] private ITimerComponent _timerComponent;

    protected override void Configure(IContainerBuilder builder)
    {
        // クラスを直接登録 (非MonoBehaviorクラス)
        builder.Register<Timer>(Lifetime.Singleton);
        // クラスをインターフェースとして登録
        // builder.Register<ITimer, Timer>(Lifetime.Singleton);

        // ゲームオブジェクトの登録(MonoBehaviorを継承したクラス)
        builder.RegisterInstance(_timerComponent);
        builder.RegisterInstance<ITimerComponent>(_timerComponent);
    }
}
