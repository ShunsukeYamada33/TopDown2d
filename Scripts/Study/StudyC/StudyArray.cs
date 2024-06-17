using UnityEngine;

public class StudyArray : MonoBehaviour
{
    // 配列
    // 大量のデータを扱う場合の仕組みの一つ
    // 初期化の時点でデータの要素数を決定する必要がある。

    void Start()
    {
        // 型[] 名前 = new 型[インデックス(添字)と呼ばれる整数];
        int[] ints01 = new int[4];
        int[] ints02 = { 1, 2, 3, 5 };

        // 使い方
        // 0から始まる
        ints01[0] = 1;
        ints01[1] = 2;
        int answer = ints01[2] + ints01[3];
        // 要素数を超えるインデックスを指定してはいけない
        // ints01[4] = 5;

        // 特殊な使い方
        // 要素数を取得する
        int length = ints01.Length;

        // 他の型でも使用可能
        float[] floats = new float[4];
        string[] strings = new string[4];
        bool[] bools = new bool[4];

        Debug.Log(answer);
        Debug.Log(floats);
        Debug.Log(strings);
        Debug.Log(bools);
        Debug.Log(length);
    }
}
