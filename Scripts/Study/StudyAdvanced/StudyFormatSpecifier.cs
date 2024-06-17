using System;
using UnityEngine;

public class StudyFormatSpecifier : MonoBehaviour
{
    // 書式指定子
    // 書式を指定して文字列内へデータを挿入するために使用

    // 書式
    // 4桁0埋め  10 → 0010
    // 小数2桁   10 → 10.00
    // パーセント 10 → 1000.00%

    // やり方３種類
    // String.Format(書式, 数値1, 数値2,...);
    // (数値).ToString(書式);
    // 文字列補完式 interpolation
    private void Start()
    {
        var number = 1234.567;

        // String.Format
        // 挿入したいデータを{}で囲む
        // {0} １つ目
        // {1} ２つ目
        // 複数のデータを一度にフォーマットできる
        Debug.Log(String.Format("Number is {0}", number));

        // ToString()
        // 単一のデータをフォーマットする際にし利用
        Debug.Log("Number is " + number.ToString());

        // 文字列補完式 interpolation
        // コードの読みやすさとメンテナンス性がある
        Debug.Log($"Number is {number}");


        // フォーマットの指定
        // N 数値 Number  1,234.567
        // 後ろの数字は小数以下の桁数 N2 1,234.57
        Debug.Log(String.Format("N2 is {0:N2}", number));
        Debug.Log(String.Format("N2 is " + number.ToString("N2")));

        // F 固定小数点 Fixed-point 1234,567
        // F2 1234.57
        Debug.Log(String.Format("F2 is {0:F2}", number));
        Debug.Log(String.Format("F2 is " + number.ToString("F2")));

        // P パーセンテージ Percent 
        // P2 123,456.70%
        Debug.Log(String.Format("P2 is {0:P2}", number));
        Debug.Log(String.Format("P2 is " + number.ToString("P2")));

        var numberInt = 123;
        // D 10進数 Decimal
        // 整数のみ利用可能
        // D5 指定された桁数に満たない場合は左側にゼロが追加　00123
        Debug.Log(String.Format("D5 is {0:D5}", numberInt));
        Debug.Log(String.Format("D5 is " + numberInt.ToString("D5")));
    }

    // 通貨、16進数、指数
    // 日付、時刻のフォーマットもある
}
