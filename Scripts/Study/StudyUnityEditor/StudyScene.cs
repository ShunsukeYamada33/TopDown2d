using UnityEngine;
using UnityEngine.SceneManagement;

public class StudyScene : MonoBehaviour
{
    // シーンの切り替え

    private void Start()
    {
        SceneManager.LoadScene("Scene3");
    }
}
