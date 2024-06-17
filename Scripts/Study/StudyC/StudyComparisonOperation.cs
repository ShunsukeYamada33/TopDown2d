using UnityEngine;

public class StudyComparisonOperation : MonoBehaviour
{
    // 比較演算
    // bool が答えとなる計算方法01

    void Start()
    {
        int int01 = 1;

        // 左は右より大きい 正しければ true 間違っていれば false
        bool answer01 = int01 > 0; // true
        // 左は右以上 正しければ true 間違っていれば false
        bool answer02 = int01 >= 0; // true
        // 左は右より小さい 正しければ true 間違っていれば false
        bool answer03 = int01 < 0; // false
        // 左は右以下 正しければ true 間違っていれば false
        bool answer04 = int01 <= 0; // false
        // 左と右の値が等しい 正しければ true 間違っていれば false
        bool answer05 = int01 == 0; // false
        // 左と右の値が異なる 正しければ true 間違っていれば false
        bool answer06 = int01 != 0; // true

        // float 型も計算可能
        bool answer07 = 1.0f > 0.0f; // true

        // string と bool は == != のみ可能
        //bool answer08 = "こんにちは" >  "こんにちは";
        bool answer09 = "こんにちは" ==  "こんにちは";
        //bool answer10 = false > true;
        bool answer11 = true == false;

        Debug.Log(answer01);
        Debug.Log(answer02);
        Debug.Log(answer03);
        Debug.Log(answer04);
        Debug.Log(answer05);
        Debug.Log(answer06);
        Debug.Log(answer07);
        //Debug.Log(answer08);
        Debug.Log(answer09);
        //Debug.Log(answer10);
        Debug.Log(answer11);
    }
}
