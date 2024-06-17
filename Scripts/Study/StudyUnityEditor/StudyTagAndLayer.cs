using UnityEngine;

public class StudyTagAndLayer : MonoBehaviour
{
    // Tag    タグ
    // Layer  レイヤー


    void Start()
    {
        //タグの取得
        string tag = gameObject.tag;
        Debug.Log(tag);

        // タグの比較
        bool compareTag = gameObject.CompareTag("Player");

        int layer = gameObject.layer;
        Debug.Log(layer);
    }
}
