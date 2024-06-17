using System.Collections.Generic;
using UnityEngine;

public class StudyNullConditionalOperator : MonoBehaviour
{
    // null 条件演算子 null-conditional operator

    // null なのか確認してから実行してくれる

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
        履歴書 resume01 = null;

        // エラーになる。
        Debug.Log(resume01.Name);

        // null の場合実行しないのでエラーになるのを防げる
        if (resume01 != null)
        {
            Debug.Log(resume01.Name);
        }

        // 変数の右に ? を付ける
        Debug.Log(resume01?.Name);

        // ? を付けることで null か確認してから実行してくれるのでエラーになるのを防げる。

        List<int> intList = null;
        // 変数の右に ? を付ける
        // インデックスの前
        Debug.Log(intList?[0]);
    }
}
