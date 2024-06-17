using UnityEngine;

public class StudyField : MonoBehaviour
{
    // フィールド スコープ ローカル変数 グローバル変数
    // フィールド メソッド外の変数のこと
    // スコープ 変数が影響を与える範囲、記憶される範囲
    // グローバル変数 どこでも利用できる変数
    // ローカル変数 特定の範囲内で利用される変数

    // フィールド例
    int field01 = 0;
    string field02 = "こんにちは";
    // フィールドは全てのメソッドで利用できる。

    void Method01()
    {
        int int01 = 10;
        Debug.Log(int01);
        Debug.Log(field01);
    }

    void Start()
    {
        // フィールドを利用できる
        int answer01 = field01 + 1;
        Debug.Log(answer01);
        Debug.Log(field02);

        // 他のメソッドの変数は利用できない
        //int answer02 = int01 + 1;

        // スコープ
        for (int i = 0; i < 10; i++)
        {
            int int02 = 0;
            Debug.Log(int02);
        }

        // if for while switch foreach などの {} で宣言した変数も利用できない。
        // int answer03 = int02 + 1;

        // 上の記載のように利用できる範囲がある。
        // その範囲をその変数の "スコープ" と言う。
        // フィールドは全てのメソッドで利用できるので "グローバル変数" と言う。
        // メソッド内の変数は利用できる範囲があるので "ローカル変数" と言う。
    }
}
