using UnityEngine;

public class StudyComparisonOperation : MonoBehaviour
{
    // ��r���Z
    // bool �������ƂȂ�v�Z���@01

    void Start()
    {
        int int01 = 1;

        // ���͉E���傫�� ��������� true �Ԉ���Ă���� false
        bool answer01 = int01 > 0; // true
        // ���͉E�ȏ� ��������� true �Ԉ���Ă���� false
        bool answer02 = int01 >= 0; // true
        // ���͉E��菬���� ��������� true �Ԉ���Ă���� false
        bool answer03 = int01 < 0; // false
        // ���͉E�ȉ� ��������� true �Ԉ���Ă���� false
        bool answer04 = int01 <= 0; // false
        // ���ƉE�̒l�������� ��������� true �Ԉ���Ă���� false
        bool answer05 = int01 == 0; // false
        // ���ƉE�̒l���قȂ� ��������� true �Ԉ���Ă���� false
        bool answer06 = int01 != 0; // true

        // float �^���v�Z�\
        bool answer07 = 1.0f > 0.0f; // true

        // string �� bool �� == != �̂݉\
        //bool answer08 = "����ɂ���" >  "����ɂ���";
        bool answer09 = "����ɂ���" ==  "����ɂ���";
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
