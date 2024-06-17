using UnityEngine;

public class StudyVariables : MonoBehaviour
{
    // 変数

    // 値を保存しておく入れ物のこと
    // いくつか種類がある
    // 整数、小数、文字列、真偽

    void Start()
    {
        // 型 名前（基本的に自由) ;
        int variable = 0;


        // 整数 0, 1, -1
        int int01 = 0;

        // 小数 0f, 0.0f, 1.0f, -1.0f
        float float01 = 0.0f;

        // 文字列 "", "あいうえお", "String", "Hello World!"
        string string01 = "";

        // 真偽 true, false
        bool bool01 = false;

        // = の役割は 右の値を左に代入する
        int01 = 10;
        float01 = 10.0f;
        string01 = "はろー";
        bool01 = true;
        // 同じ 型 にしか代入できない。

        // 違う 型 にいれようとすると基本的にエラーになる
        //int01 = float01;

        Debug.Log(variable);
        Debug.Log(int01);
        Debug.Log(float01);
        Debug.Log(string01);
        Debug.Log(bool01);
        Debug.Log(string01);
    }
}
