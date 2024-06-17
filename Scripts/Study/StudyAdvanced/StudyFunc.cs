using System;
using UnityEngine;

public class StudyFunc : MonoBehaviour
{
    // デリゲートのFunc

    // 定義済のデリゲート
    // 宣言をする必要がないデリゲートのこと
    // Func は戻り値のある定義済みのデリゲートのこと

    private void MainMethod()
    {
        // 省略できる
        // private delegate 型 Func();
        Func<string> action01 = Method01;

        // 引数ありも可能
        // Action<引数１, ......., 戻り値の型>
        Func<int, string> action02 = Method02;
        Func<int, int, string> action03 = Method03;

        string answer01 = action01.Invoke();
        string answer02 = action02.Invoke(0);
        string answer03 = action03.Invoke(0, 1);


        // ラムダも使用できる
        Func<string> action04 = () => { return "追加アクション"; };
        // メソッドの追加
        action04 += Method01;

        action04.Invoke();
    }

    private string Method01()
    {
        return "ファンク";
    }

    private string Method02(int score)
    {
        return "スコアは" + score;
    }

    private string Method03(int score01, int score02)
    {
        var sum = score01 + score02;
        return "スコアは" + sum;
    }
}
