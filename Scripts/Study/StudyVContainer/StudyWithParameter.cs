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
        // 登録する際に同じクラスを使用したい場合に等に使える。
        // Injectで取得する際に名前を付けて登録できる。
        builder.Register<UseWithParameter>(Lifetime.Singleton)
            .WithParameter("text01", text01)
            .WithParameter("text02", text02);
    }
}
