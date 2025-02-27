using UnityEngine;
using UnityEngine.UI;

public class StudyImage : MonoBehaviour
{
    // Image
    // UIの画像

    private Image _image;
    public Sprite sprite;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }


    void Start()
    {
        _image.sprite = sprite;
        _image.raycastTarget = true;
        // type が Fillの時にどの程度画像を埋めるか
        _image.fillAmount = 0.5f;
    }
}
