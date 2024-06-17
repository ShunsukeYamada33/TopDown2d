using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;

public class BattleLifeTimeScope : LifetimeScope
{
    // VCountainer �ˑ����̒���������Ă����c�[��
    // LifetimeScope VContainer �̋@�\�̈�ŋ�̓I�ɂ���Ă����@�\
    //               MonoBehaviour ��Awake Start�̂悤�ȃ��C�t�T�C�N��������ɂ���Ă����B

    [SerializeField] private PlayerObject player;
    [SerializeField] private MapManager mapManager;
    [SerializeField] private TextMeshProUGUI enemiesCountText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private Slider experienceSlider;
    [SerializeField] private RewardPanel rewardPanel;
    [SerializeField] private GameClearPanel gameClearPanel;
    [SerializeField] private Timer timer;

    protected override void Configure(IContainerBuilder builder)
    {
        builder.RegisterInstance(player);
        builder.RegisterInstance(mapManager);
        builder.RegisterInstance(experienceSlider);
        builder.RegisterInstance(rewardPanel);
        builder.RegisterInstance(gameClearPanel);
        builder.RegisterInstance(timer);

        builder.Register<GameClearManager>(Lifetime.Singleton);

        builder.RegisterEntryPoint<EnemiesCountPresenter>()
            .WithParameter("enemiesCountText", enemiesCountText);
        builder.RegisterEntryPoint<LevelPresenter>()
            .WithParameter("levelText", levelText);
        builder.RegisterEntryPoint<RewardPresenter>();
        builder.RegisterEntryPoint<GameClearPresenter>();

#if UNITY_WEBGL
        builder.Register<ISaveData, SavePlayerPrefs>(Lifetime.Singleton);
#else
        builder.Register<ISaveData, SaveFile>(Lifetime.Singleton);
#endif
    }
}
