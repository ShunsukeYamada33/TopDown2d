using R3;
using UnityEngine;

public class StudyReactiveProperty : MonoBehaviour
{
    // ReactiveProperty

    // リアクティブプログラミングとは
    // 何か値が変更されると、自動で何か処理を実行する。
    // HPが変化すると、自動でスライダーを変える。

    public ReactiveProperty<int> reactivePropertyInt = new(100);

    private void Start()
    {
        reactivePropertyInt.Subscribe(x => Debug.Log(x));
        reactivePropertyInt.Subscribe(DebugInt);

        // 値を変更する場合は.Valueを変える
        // 値を変えると通知
        reactivePropertyInt.Value = 10;
    }

    private void DebugInt(int integer)
    {
        Debug.Log(integer);
    }

    // 10
    // 10




    // 応用編
    // 他のクラスで数値を変えられると困る。

    // 通知を受ける機能だけを公開する .Subscribe
    public ReadOnlyReactiveProperty<int> ReactivePropertyInt => reactivePropertyInt;

    public void Method02()
    {
        ReactivePropertyInt.Subscribe(x => Debug.Log(x));
    }



}
