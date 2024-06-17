using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class StudySlider : MonoBehaviour
{
    // �X���C�_�[

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    void Start()
    {
        // �ő�l
        _slider.maxValue = 10;
        // �ŏ��l
        _slider.minValue = 0;


        // ���݂̒l
        _slider.value = 0;

        // value�� min �� max �̊Ԃ̒l�����Ƃ�Ȃ����߁A�ݒ菇�ɒ���
        // slider.value = 100;
        // slider.maxValue = 100;
        // slider.value �̒l�� 10 �ɂȂ��Ă��܂��B

        _slider.onValueChanged.AddListener(OnSliderValueChanged);
        _slider.onValueChanged.AddListener((value) => OnSliderValueChanged(value));
    }

    public void OnSliderValueChanged(float value)
    {
        Debug.Log(value);
    }
}
