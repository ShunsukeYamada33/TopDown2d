using System.Collections.Generic;
using UnityEngine;

public class StudyList : MonoBehaviour
{
    // リスト
    // 大量のデータを扱う場合の仕組みの一つ
    // 初期化の時点でデータの要素数を決定する必要がない。
    // 後から自由に要素数を変えられる。

    void Start()
    {
        List<int> intList01 = new List<int>();
        List<int> intList02 = new();
        List<int> intList03 = new List<int>() { 1, 2, 3, 4 };
        List<int> intList04 = new() { 1, 2, 3, 4 };

        // 使い方
        intList03[0] = 4;
        intList03[1] = 5;
        int answer = intList03[2] + intList03[3];

        // 要素数を超えるインデックスを指定してはいけない
        // intList03[4] = 3;

        // 要素数の取得
        int count = intList03.Count;


        // 他の型でも使用可能
        List<float> floatList01 = new List<float>();
        List<string> stringList01 = new List<string>();
        List<bool> boolList01 = new List<bool>();

        //要素の追加
        intList01.Add(3); // { 3 }
        intList01.Add(4); // { 3, 4 }

        //要素の削除
        //値を指定して削除
        intList01.Remove(3); // { 4 }

        // インデックスを指定して削除
        // 要素数を超えるインデックスを指定してはいけない
        intList01.RemoveAt(0); // { }

        // 値の検索
        bool is3 = intList03.Contains(3);

        // リストのクリア
        intList04.Clear(); // { }

        // 他にも機能がたくさんあるのでやりたいことができたら調べる癖を!
    }
}
