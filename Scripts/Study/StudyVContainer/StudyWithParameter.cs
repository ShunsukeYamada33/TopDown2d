using TMPro;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyWithParameter : LifetimeScope
{
    [SerializeField] private TextMeshProUGUI text01;
    [SerializeField] private TextMeshProUGUI text02;

    protected override void Configure(IContainerBuilder builder)
    {
        // �o�^����ۂɓ����N���X���g�p�������ꍇ�ɓ��Ɏg����B
        // Inject�Ŏ擾����ۂɖ��O��t���ēo�^�ł���B
        builder.Register<UseWithParameter>(Lifetime.Singleton)
            .WithParameter("text01", text01)
            .WithParameter("text02", text02);
    }
}
