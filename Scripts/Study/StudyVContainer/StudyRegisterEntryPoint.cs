using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyRegisterEntryPoint : LifetimeScope
{
    // RegisterEntryPoint
    // MonoBehaviorのライフサイクルを非MonoBehaviorでも利用できるようにする。

    protected override void Configure(IContainerBuilder builder)
    {

        builder.RegisterEntryPoint<EntryPoint>();
    }
}
