using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyRegister : LifetimeScope
{
    // Register
    // ��{�I�ȓo�^���@

    [SerializeField] private ITimerComponent _timerComponent;

    protected override void Configure(IContainerBuilder builder)
    {
        // �N���X�𒼐ړo�^ (��MonoBehavior�N���X)
        builder.Register<Timer>(Lifetime.Singleton);
        // �N���X���C���^�[�t�F�[�X�Ƃ��ēo�^
        // builder.Register<ITimer, Timer>(Lifetime.Singleton);

        // �Q�[���I�u�W�F�N�g�̓o�^(MonoBehavior���p�������N���X)
        builder.RegisterInstance(_timerComponent);
        builder.RegisterInstance<ITimerComponent>(_timerComponent);
    }
}
