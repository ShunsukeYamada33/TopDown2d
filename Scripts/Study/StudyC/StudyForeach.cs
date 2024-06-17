using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyForeach : MonoBehaviour
{
    // foreach
    // 配列、List、Dictionaryを利用した繰り返し処理

    void Start()
    {
        List<int> intList01 = new() { 3, 4, 5, 6 };

        // foreach ( 型 変数名 in リスト等)
        // {
        //    処理
        // }

        int sum01 = 0;
        foreach (int integer in intList01)
        {
            sum01 += integer;
        }

        // リストから一つずつ取り出して処理をできる。
        // リストを操作する際にインデックスの扱いを間違えるとエラーになるが、
        // foreachはその心配がない。

        // Listにインデックスを指定して取得するのは基本使わない。

        // for を利用した記述もできる。
        int sum02 = 0;
        for (int i = 0; i < intList01.Count; i++)
        {
            sum02 += intList01[i];
        }



        int[] ints = { 3, 4, 5, 6, };
        int sum03 = 0;
        foreach (int integer in ints)
        {
            sum03 += integer;
        }

        // Dictionaryは応用
        Dictionary<string, int> keyValuePairs = new() { { "山田", 3 }, { "田中", 5 } };
        int sum04 = 0;
        foreach (KeyValuePair<string, int> keyValuePair in keyValuePairs)
        {
            sum04 += keyValuePair.Value;
        }
    }
}
