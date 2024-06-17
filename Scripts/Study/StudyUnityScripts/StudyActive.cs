using UnityEngine;

public class StudyActive : MonoBehaviour
{
    // SetActive
    // activeSelf

    private void Start()
    {
        // ゲームオブジェクトのアクティブを切り替える
        gameObject.SetActive(false);
        gameObject.SetActive(true);

        // アクティブかどうか取得できる。
        Debug.Log(gameObject.activeSelf);
    }
}
