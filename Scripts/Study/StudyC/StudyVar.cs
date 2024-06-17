using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StudyVar : MonoBehaviour
{
    // var 型推論
    // 暗黙的型指定ローカル変数

    void Start()
    {
        // 整数で初期化すると自動的に int
        var int01 = 0;
        // 数値の末尾に f を付けると自動的に float
        var float01 = 0.0f;
        // "" で囲むと自動的に string
        var string01 = "こんにちは";
        // true または false だと自動的に bool
        var bool01 = false;

        var intList = new List<int>();
        var keyValuePairs = new Dictionary<string, string>();

        // メリット
        // var という３文字で固定されるので変数名が見やすい
        // foreach や for といった際の初期化が楽( KeyValuePair<string, string> )
        foreach (var keyValue in keyValuePairs)
        {
            Debug.Log(keyValue.Key);
        }

        // デメリット
        // 型が何かわかりにくい
        var int02 = int01;
        var float02 = float01;
        var string02 = string01;
        var bool02 = bool01;
        var list = GetList();

        Debug.Log(int02);
        Debug.Log(float02);
        Debug.Log(string02);
        Debug.Log(bool02);
        Debug.Log(list);
    }

    // フィールド(グローバル変数)には使用できない。
    // ローカル変数のみ var を使用可能
    // var int02 = 0;




    private List<bool> GetList()
    {
        var list = new List<bool>();
        return list;
    }
}
