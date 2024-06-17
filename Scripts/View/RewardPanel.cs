using R3;
using R3.Triggers;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

public class RewardPanel : MonoBehaviour
{
    public List<RewardButton> rewardButtons;
    public Image enButton;
    public Image jaButton;

    private void Start()
    {
        enButton.OnPointerClickAsObservable().Subscribe(_ => SetLocale("en"));
        jaButton.OnPointerClickAsObservable().Subscribe(_ => SetLocale("ja"));
    }

    public void Selected()
    {
        rewardButtons[1].selectable.Select();
    }

    private void SetLocale(string key)
    {
        var locale = LocalizationSettings.AvailableLocales.GetLocale(key);
        if (locale != null)
        {
            LocalizationSettings.SelectedLocale = locale;
        }
    }
}
