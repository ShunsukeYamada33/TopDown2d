using UnityEngine;

public class StudyLifeCycleActive : MonoBehaviour
{
    // ライフサイクルイベント アクティブに関係する

    // Unity のゲームオブジェクトが生存中に実行される処理

    private void Awake()
    {
        // このクラス(ゲームオブジェクトが最初にロード（読み込まれた）されたタイミング
        // １度実行
        // 一番最初
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // ゲームオブジェクトがアクティブになったタイミング
        // 何度も実行
        // 2番目
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // ゲームオブジェクトが動き出す直前のタイミング
        // １度実行
        // 3番目
        Debug.Log("Start");
    }

    private void OnDisable()
    {
        // ゲームオブジェクトが非アクティブになったタイミング
        // 何度も実行
        Debug.Log("OnDisable");
    }
}
