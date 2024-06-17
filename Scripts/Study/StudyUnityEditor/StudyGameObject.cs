using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    // GameObject

    [SerializeField] private StudyGameObject study;

    void Start()
    {
        // 自身のGameObjectの取得方法
        Debug.Log(gameObject);
        Debug.Log(study.gameObject);


        // ゲームオブジェクトの名前
        string gameObjectName = gameObject.name;
        Debug.Log(gameObjectName);
    }
}
