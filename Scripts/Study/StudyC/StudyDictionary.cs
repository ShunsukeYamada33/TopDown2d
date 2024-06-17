using System.Collections.Generic;
using UnityEngine;

public class StudyDictionary : MonoBehaviour
{
    // Dictionary
    // 大量のデータを扱う場合の仕組みの一つ
    // Key と呼ばれる名前
    // Value と呼ばれる値
    // Key と Value をセットで扱う
    // Listはインデックスと値をセットだがDictionaryのKeyの型は自由
    // Key の重複はしない

    void Start()
    {
        Dictionary<string, int> keyValuePairs01 = new Dictionary<string, int>();
        Dictionary<string, int> keyValuePairs02 = new();
        Dictionary<string, int> keyValuePairs03 = new() { { "山田", 3 }, { "佐藤", 4 } };



        // 使い方
        keyValuePairs03["山田"] = 4;
        keyValuePairs03["佐藤"] = 5;
        int answer = keyValuePairs03["山田"] + keyValuePairs03["佐藤"];

        // 存在しないKeyを指定してはいけない。
        // intList03["田中"] = 3;

        // 要素数の取得
        int count = keyValuePairs03.Count;


        // 他の型でも使用可能
        Dictionary<int, string> intStringPair01 = new();
        Dictionary<float, float> floatFloatPair01 = new();
        Dictionary<bool, int> boolIntPair01 = new();

        //要素の追加
        keyValuePairs01.Add("五十嵐", 4);
        keyValuePairs01.Add("七五三", 5);

        //要素の削除
        //値を指定して削除
        keyValuePairs01.Remove("五十嵐");


        // 値の検索
        bool isKey = keyValuePairs01.ContainsKey("七五三");

        // ※
        // Dictionary は Key の重複が許されていない
        // Add で Key がすでにある場合はエラー
        if (!keyValuePairs01.ContainsKey("七五三"))
        {
            // Key が存在していない場合のみ追加したほうがよい
            keyValuePairs01.Add("五十嵐", 4);
        }

        // Dictionaryのクリア
        keyValuePairs01.Clear();

        // 他にも機能がたくさんあるのでやりたいことができたら調べる癖を!
    }
}
