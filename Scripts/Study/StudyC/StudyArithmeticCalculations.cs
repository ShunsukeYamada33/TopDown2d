using UnityEngine;

public class StudyArithmeticCalculations : MonoBehaviour
{
    // Zp‰‰Z
    // ŒvZ‚Ì‚±‚Æ(l‘¥‰‰Z)
    // PC‚Í“dqŒvZ‹@

    void Start()
    {
        int int01 = 10;
        float float01 = 1.0f;
        string string01 = "‚ ‚¢‚¤";
        string string02 = "‚¦‚¨";



        // ‘«‚µZ
        int answer01 = 1 + 2; // 3
        // ˆø‚«Z
        int answer02 = 1 - 2; // -1
        // Š|‚¯Z
        int answer03 = 1 * 2; // 2
        // Š„‚èZ
        int answer04 = 1 / 2; // 0 ¦int®”‚È‚Ì‚Å0.5‚Æ‚Í‚È‚ç‚È‚¢
        // —]Z
        int answer05 = 1 % 2; // 1


        // •Ï”‚ğŠÜ‚ß‚½ŒvZ‚à‚Å‚«‚éB
        int answer06 = answer01 + int01 + 2;

        // Šî–{“I‚È”’lŒvZ‚ÉŠÖ‚µ‚Ä‚ÍA”Šw‚Æ“¯‚¶ƒ‹[ƒ‹‚É]‚¤
        int answer07 = 3 * (4 + 2) + 2 * 3; // 24


        // “Áê‚ÈŒvZ
        int answer08 = 0;
        answer08 += 3; // answer08 = answer08 + 3
        answer08 -= 3; // answer08 = answer08 - 3
        answer08 *= 3; // answer08 = answer08 * 3
        answer08 /= 3; // answer08 = answer08 / 3
        answer08 %= 3; // answer08 = answer08 % 3

        int answer09 = 0;
        // ƒCƒ“ƒNƒŠƒƒ“ƒg
        answer09++; // answer09 = answer09 + 1
        // ƒfƒNƒŠƒƒ“ƒg
        answer09--; // answer09 = answer09 - 1


        // float ‚à int ‚Æ“¯—l‚ÉŒvZ‚Å‚«‚éB
        float answer10 = 1.0f + float01;

        // float ‚Æ int ‚ÌŒvZ‚Í’ˆÓ
        float answer11 = float01 + int01;
        //int answer12 = float01 + int01;

        // string ‚Í‘«‚µZ‚Ì‚İ‰Â”\
        // •¶š—ñ‚ªŒ‹‡‚·‚é
        string answer13 = string01 + string02;
        //string answer14 = string01 - string03;

        // bool ‚ÍZp‰‰Z‚Å‚«‚È‚¢
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
