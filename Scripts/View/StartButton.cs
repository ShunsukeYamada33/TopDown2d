using R3;
using R3.Triggers;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        // SceneManager.LoadScene(�V�[����)
        _image.OnPointerClickAsObservable().Subscribe(_ => SceneManager.LoadScene("BattleScene"));
    }
}
