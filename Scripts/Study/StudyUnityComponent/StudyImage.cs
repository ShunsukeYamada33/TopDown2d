using UnityEngine;
using UnityEngine.UI;

public class StudyImage : MonoBehaviour
{
    // Image
    // UI�̉摜

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
        // type �� Fill�̎��ɂǂ̒��x�摜�𖄂߂邩
        _image.fillAmount = 0.5f;
    }
}
