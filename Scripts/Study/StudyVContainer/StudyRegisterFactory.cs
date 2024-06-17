using UnityEngine;
using VContainer;
using VContainer.Unity;

public class StudyRegisterFactory : LifetimeScope
{
    // RegisterFactory
    // ��`�ς݃f���Q�[�g��Func<>��o�^����B
    // MonoBehaviour ���p������K�v�����郁�\�b�h���MonoBehaviour�N���X�Ŏg�p�ł���B
    // Instantiate���g�p�ł���B

    [SerializeField] private RegisterFactory _registerFactoryPrefab;

    protected override void Configure(IContainerBuilder builder)
    {
        // ���\�b�h��o�^ <�����P, �����Q, ..... , �߂�l>(���\�b�h);
        builder.RegisterFactory<RegisterFactoryData, IRegisterFactory>(CreateObject);

        // �����_����o�^���邱�Ƃ��������\
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
