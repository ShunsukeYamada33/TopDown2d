using System.Collections.Generic;
using UnityEngine;

public class StudyReadonly : MonoBehaviour
{
    // readonly
    // 書き換え不可能なフィールドを作成できる

    // アクセス修飾子　readonly 型 名前
    private readonly int _int = 0;

    private void Method01()
    {
        // 他の値を代入しようとするとエラーになるようになる。
        // _int01 = 2;
        Debug.Log(_int);
    }

    // static を付ける場合
    // アクセス修飾子 static readonly 型 名前
    private static readonly int Int = 0;

    // class, 配列, List, Dictionary 等でも使える
    private readonly Character _character = new();
    private readonly List<int> _intList = new();

    private void Method02()
    {
        // readonly class のフィールドの値を変えることはできる。
        _character.name = "戦士";

        // 新しい class の代入は不可
        // _character = new();

        // Listの要素の追加, 要素の値の変更などはできる
        _intList.Add(Int);
        _intList[0] = 3;

        // 新しい List の代入は不可
        // _intList = new();

        // あくまでもそのインスタンスが持つ要素は変えられるが、そのものは変えられない
    }


    private class Character
    {
        public string name;
    }
}
