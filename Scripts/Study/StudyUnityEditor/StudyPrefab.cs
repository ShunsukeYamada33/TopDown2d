using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class StudyPrefab : MonoBehaviour
{
    // Prefab プレファブ
    // ゲームオブジェクトのテンプレート

    [SerializeField] private StudyPrefab studyPrefab;

    private void Start()
    {
        // Instantiate を利用して複製して利用する。
        Instantiate(studyPrefab);
    }
}
