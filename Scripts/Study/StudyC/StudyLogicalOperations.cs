using UnityEngine;

public class StudyLogicalOperations : MonoBehaviour
{
    // 論理演算
    // bool が答えとなる計算方法02

    void Start()
    {
        // && 論理積 AND
        // 左が true かつ 右が true ならば true、それ以外は false
        bool answer01 = true && true; // true
        bool answer02 = true && false; // false
        bool answer03 = false && false; // false

        // || 論理和 OR
        // 左が true または 右が true ならば true, それ以外は false
        bool answer04 = true || true; // true
        bool answer05 = true || false; // true
        bool answer06 = false || false; // false

        // ! 否定 NOT
        bool answer07 = !true; // false
        bool answer08 = !false; // true

        // 実践
        int int01 = 10;
        int int02 = 20;
        bool answer09 = (int01 > 15) || (int02 > 15);
        bool answer10 = (int01 > 3) && (int01 <= 5) || !(int02 <= 6);

        // 計算の優先順位
        // () カッコ内の計算
        // ++ -- インクリメント、デクリメント
        // */% 掛算と割算と余算
        // +- 足算と引算
        // 比較演算
        // &&
        // ||
        // = += -= *= /= %=

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
    }
}
