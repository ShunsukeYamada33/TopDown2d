using R3;
using R3.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class StudyObservable : MonoBehaviour
{
    // Observable
    // その他のSubscribeできるもの

    private void Start()
    {
        // 5秒後に1回だけ処理を実行
        Observable.Timer(System.TimeSpan.FromSeconds(5.0f)).Subscribe(Log);

        // Updateのタイミングで実行し続ける
        // Unityのイベント系は全部使えるはず ○○AsObservable()
        gameObject.UpdateAsObservable().Subscribe(Log);

        var button = GetComponent<Button>();
        button.OnClickAsObservable().Subscribe(Log);
    }

    private void Log(Unit _)
    {
        Debug.Log("");
    }
}
