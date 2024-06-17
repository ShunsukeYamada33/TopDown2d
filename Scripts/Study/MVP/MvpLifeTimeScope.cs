using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;

public class MvpLifeTimeScope : LifetimeScope
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Slider slider;

    protected override void Configure(IContainerBuilder builder)
    {
        // Model
        builder.Register<CharacterModel>(Lifetime.Singleton);

        // View
        builder.Register<CharacterView>(Lifetime.Singleton);
        builder.RegisterInstance(text);
        builder.RegisterInstance(slider);

        builder.RegisterEntryPoint<CharacterPresenter>();
    }
}
