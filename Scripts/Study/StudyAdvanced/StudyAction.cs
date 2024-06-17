using System;
using UnityEngine;

public class StudyAction : MonoBehaviour
{
    // デリゲートのAction

    // 定義済のデリゲート
    // 宣言をする必要がないデリゲートのこと
    // Action は戻り値のない定義済みのデリゲートのこと

    private void MainMethod()
    {
        // 省略できる
        // private delegate void Action();
        Action action01 = Method01;

        // 引数ありも可能
        // Action<引数１, ......>
        Action<string> action02 = Method02;
        Action<string, string> action03 = Method03;

        action01.Invoke();
        action02.Invoke("アクション");
        action03.Invoke("アクション01", "アクション02");


        // ラムダも使用できる
        Action action04 = () => Debug.Log("追加アクション");
        // メソッドの追加
        action04 += Method01;

        action04.Invoke();
    }

    private void Method01()
    {
        Debug.Log("アクション");
    }

    private void Method02(string text)
    {
        Debug.Log(text);
    }

    private void Method03(string text01, string text02)
    {
        Debug.Log(text01 + text02);
    }
}
