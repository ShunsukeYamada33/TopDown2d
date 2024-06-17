using UnityEngine;
using UnityEngine.UI;

public class StudyImage : MonoBehaviour
{
    // Image
    // UI‚Ì‰æ‘œ

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
        // type ‚ª Fill‚ÌŽž‚É‚Ç‚Ì’ö“x‰æ‘œ‚ð–„‚ß‚é‚©
        _image.fillAmount = 0.5f;
    }
}
