using UnityEngine;

public class StudyArithmeticCalculations : MonoBehaviour
{
    // 算術演算
    // 計算のこと(四則演算)
    // PCは電子計算機

    void Start()
    {
        int int01 = 10;
        float float01 = 1.0f;
        string string01 = "あいう";
        string string02 = "えお";



        // 足し算
        int answer01 = 1 + 2; // 3
        // 引き算
        int answer02 = 1 - 2; // -1
        // 掛け算
        int answer03 = 1 * 2; // 2
        // 割り算
        int answer04 = 1 / 2; // 0 ※int整数なので0.5とはならない
        // 余算
        int answer05 = 1 % 2; // 1


        // 変数を含めた計算もできる。
        int answer06 = answer01 + int01 + 2;

        // 基本的な数値計算に関しては、数学と同じルールに従う
        int answer07 = 3 * (4 + 2) + 2 * 3; // 24


        // 特殊な計算
        int answer08 = 0;
        answer08 += 3; // answer08 = answer08 + 3
        answer08 -= 3; // answer08 = answer08 - 3
        answer08 *= 3; // answer08 = answer08 * 3
        answer08 /= 3; // answer08 = answer08 / 3
        answer08 %= 3; // answer08 = answer08 % 3

        int answer09 = 0;
        // インクリメント
        answer09++; // answer09 = answer09 + 1
        // デクリメント
        answer09--; // answer09 = answer09 - 1


        // float も int と同様に計算できる。
        float answer10 = 1.0f + float01;

        // float と int の計算は注意
        float answer11 = float01 + int01;
        //int answer12 = float01 + int01;

        // string は足し算のみ可能
        // 文字列が結合する
        string answer13 = string01 + string02;
        //string answer14 = string01 - string03;

        // bool は算術演算できない
        //bool answer15 = bool01 + bool02;

        Debug.Log(answer01);
        Debug.Log(answer02);
        Debug.Log(answer03);
        Debug.Log(answer04);
        Debug.Log(answer05);
        Debug.Log(answer06);
        Debug.Log(answer07);
        Debug.Log(answer08);
        Debug.Log(answer09);
        Debug.Log(answer10);
        Debug.Log(answer11);
        //Debug.Log(answer12);
        Debug.Log(answer13);
        //Debug.Log(answer14);
        //Debug.Log(answer15);
    }
}
