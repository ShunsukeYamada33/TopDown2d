using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyRegisterEntryPoint : LifetimeScope
{
    // RegisterEntryPoint
    // MonoBehavior�̃��C�t�T�C�N�����MonoBehavior�ł����p�ł���悤�ɂ���B

    protected override void Configure(IContainerBuilder builder)
    {

        builder.RegisterEntryPoint<EntryPoint>();
    }
}
