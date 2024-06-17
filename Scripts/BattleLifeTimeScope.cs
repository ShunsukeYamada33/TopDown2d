using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;

public class BattleLifeTimeScope : LifetimeScope
{
    // VCountainer 依存性の注入をやってくれるツール
    // LifetimeScope VContainer の機能の一つで具体的にやってくれる機能
    //               MonoBehaviour のAwake Startのようなライフサイクルも代わりにやってくれる。

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
