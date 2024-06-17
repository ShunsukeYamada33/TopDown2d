using R3;
using UnityEngine;

public class StudySubject : MonoBehaviour
{
    // Subject

    // リアクティブプログラミングとは
    // 何か値が変更されると、自動で何か処理を実行する。
    // 敵キャラクターが死亡すると、マップのキャラクターの残りＮ体といった表示の切り替え、倒した敵の統計データをインクリメントする

    // リアクティブプログラミングで基本の機能
    // Subject    通知するクラス
    // OnNext     通知する
    // Subscribe  通知を受け取る

    // 数値を添えて通知する
    private Subject<int> subjectInt = new();

    // 特に何の値もなしに通知だけする。
    private Subject<Unit> subjectUnit = new();

    private void Method01()
    {
        // 通知を受け取ることを宣言する。 .Subscribe(デリーゲート);
        subjectInt.Subscribe(x => Debug.Log(x));
        subjectInt.Subscribe(DebugInt);

        subjectUnit.Subscribe(_ => Debug.Log("通知"));


        // 通知する
        subjectInt.OnNext(1);
        subjectUnit.OnNext(Unit.Default);
    }

    private void DebugInt(int x)
    {
        Debug.Log(x);
    }

    // 1
    // 1
    // 通知


    // 応用編
    // 他のクラスでOnNextされると困る。
    // 他のクラスでSubscribeされると困る場合のテクニック

    // 通知を受ける機能だけを公開する .Subscribe
    public Observable<int> ObservableInt => subjectInt;

    // 通知する機能を公開する .OnNext
    public ISubject<int> ISubjectInt => subjectInt;

    public void Method02()
    {
        ObservableInt.Subscribe(x => Debug.Log(x));

        ISubjectInt.OnNext(1);
    }
}
