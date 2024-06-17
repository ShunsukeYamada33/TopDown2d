using UnityEngine;

public class StudyReturnValue : MonoBehaviour
{
    // 戻り値 return void
    // メソッドは実行結果を返すことができる。

    // 戻り値 メソッドの実行結果のこと
    // return メソッドの最後に値を返す処理。
    // value 実行結果がないことを表す型

    // 戻り値の型 メソッド名()
    int ReturnInt()
    {
        // return 値;
        return 0;
    }

    string ReturnString()
    {
        return "こんにちは";
    }

    // void 戻り値がない
    // return 使えない。
    void NoReturnValue()
    {
        //return 0;
        //return "こんにちは";
    }

    void Start()
    {
        // 戻り値の受け取り方
        int int01 = ReturnInt();
        Debug.Log(int01);

        string string01 = ReturnString();
        Debug.Log(string01);

        NoReturnValue();

        // 戻り値を受け取らないことも可能
        ReturnInt();
    }
}
