using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyNull : MonoBehaviour
{
    // null

    // プログラミング言語において「何もない」または「存在しない」状態を表す特別な値
    // クラスとは設計図、骨組み
    // インスタンスとは実物、肉

    private class 履歴書
    {
        public string Name { get; }
        public string Description { get; }
        public string Type { get; }

        public 履歴書(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }

    private void Method()
    {
        // この履歴書は null 白紙
        // 履歴書 resume01;
        履歴書 resume02 = null;

        // エラーにならないが、実行するとエラーになる
        Debug.Log(resume02.Name);

        // null の場合実行しないのでエラーになるのを防げる
        if (resume02 != null)
        {
            Debug.Log(resume02.Name);
        }

        // 必ず初期化(new)しよう。
        履歴書 resume03 = new 履歴書("Jhon", "学生", "男"); // 履歴書
        Debug.Log(resume03.Name);


        List<int> list = null;
        Debug.Log(list[0]);
        // list = new();   エラーにならない 0 
        // list;           エラーになる
        Debug.Log(list.Count);
    }
}
