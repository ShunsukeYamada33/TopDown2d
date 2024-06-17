using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyRegisterFactory : LifetimeScope
{
    // RegisterFactory
    // 定義済みデリゲートのFunc<>を登録する。
    // MonoBehaviour を継承する必要があるメソッドを非MonoBehaviourクラスで使用できる。
    // Instantiateが使用できる。

    [SerializeField] private RegisterFactory _registerFactoryPrefab;

    protected override void Configure(IContainerBuilder builder)
    {
        // メソッドを登録 <引数１, 引数２, ..... , 戻り値>(メソッド);
        builder.RegisterFactory<RegisterFactoryData, IRegisterFactory>(CreateObject);

        // ラムダ式を登録することももちろん可能
        builder.RegisterFactory<RegisterFactoryData, IRegisterFactory>((data) =>
        {
            var registerFactory = Instantiate(_registerFactoryPrefab);
            registerFactory.SetData(data);
            return registerFactory;
        });
    }

    private IRegisterFactory CreateObject(RegisterFactoryData data)
    {
        var registerFactory = Instantiate(_registerFactoryPrefab);
        registerFactory.SetData(data);
        return registerFactory;
    }
}
