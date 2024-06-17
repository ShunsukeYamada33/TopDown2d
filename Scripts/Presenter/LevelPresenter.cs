using TMPro;
using R3;
using UnityEngine.UI;
using VContainer;
using VContainer.Unity;

public class LevelPresenter : IStartable
{
    private readonly PlayerObject _playerObject;
    private readonly TextMeshProUGUI _levelText;
    private readonly Slider _experienceSlider;

    [Inject]
    public LevelPresenter(PlayerObject playerObject, TextMeshProUGUI levelText, Slider experienceSlider)
    {
        _playerObject = playerObject;
        _levelText = levelText;
        _experienceSlider = experienceSlider;
    }

    public void Start()
    {
        _playerObject.level.Subscribe(level =>
        {
            _levelText.text = level.ToString();
            _experienceSlider.maxValue = level;
        });

        _playerObject.experience.Subscribe(experience => _experienceSlider.value = experience);
    }
}
