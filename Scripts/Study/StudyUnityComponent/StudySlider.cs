using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StudySlider : MonoBehaviour
{
    // スライダー

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    void Start()
    {
        // 最大値
        _slider.maxValue = 10;
        // 最小値
        _slider.minValue = 0;


        // 現在の値
        _slider.value = 0;

        // valueは min と max の間の値しかとれないため、設定順に注意
        // slider.value = 100;
        // slider.maxValue = 100;
        // slider.value の値は 10 になってしまう。

        _slider.onValueChanged.AddListener(OnSliderValueChanged);
        _slider.onValueChanged.AddListener((value) => OnSliderValueChanged(value));
    }

    public void OnSliderValueChanged(float value)
    {
        Debug.Log(value);
    }
}
