using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyLifeTimeScope : LifetimeScope
{
    // LifetimeScope
    // 依存性の注入をしてくれるクラス

    // https://vcontainer.hadashikick.jp/ja/getting-started/hello-world

    protected override void Configure(IContainerBuilder builder)
    {
        // 注入したいものをここに追加していく
    }


    // 具体的なことは次の講座で
}
