using UnityEngine;

public class StudyLogicalOperations : MonoBehaviour
{
    // ˜_—‰‰Z
    // bool ‚ª“š‚¦‚Æ‚È‚éŒvZ•û–@02

    void Start()
    {
        // && ˜_—Ï AND
        // ¶‚ª true ‚©‚Â ‰E‚ª true ‚È‚ç‚Î trueA‚»‚êˆÈŠO‚Í false
        bool answer01 = true && true; // true
        bool answer02 = true && false; // false
        bool answer03 = false && false; // false

        // || ˜_—˜a OR
        // ¶‚ª true ‚Ü‚½‚Í ‰E‚ª true ‚È‚ç‚Î true, ‚»‚êˆÈŠO‚Í false
        bool answer04 = true || true; // true
        bool answer05 = true || false; // true
        bool answer06 = false || false; // false

        // ! ”Û’è NOT
        bool answer07 = !true; // false
        bool answer08 = !false; // true

        // À‘H
        int int01 = 10;
        int int02 = 20;
        bool answer09 = (int01 > 15) || (int02 > 15);
        bool answer10 = (int01 > 3) && (int01 <= 5) || !(int02 <= 6);

        // ŒvZ‚Ì—Dæ‡ˆÊ
        // () ƒJƒbƒR“à‚ÌŒvZ
        // ++ -- ƒCƒ“ƒNƒŠƒƒ“ƒgAƒfƒNƒŠƒƒ“ƒg
        // */% Š|Z‚ÆŠ„Z‚Æ—]Z
        // +- ‘«Z‚ÆˆøZ
        // ”äŠr‰‰Z
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
