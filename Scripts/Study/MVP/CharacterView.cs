using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;

public class CharacterView
{
    private readonly TextMeshProUGUI _text;
    private readonly Slider _slider;

    [Inject]
    public CharacterView(TextMeshProUGUI text, Slider slider)
    {
        _text = text;
        _slider = slider;
    }

    public void ChangeText()
    {
        _text.text = "You Dead!";
    }

    public void ChangeSlider(int score)
    {
        _slider.value = score;
    }
}
