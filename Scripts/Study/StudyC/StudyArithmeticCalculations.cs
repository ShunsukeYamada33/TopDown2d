using UnityEngine;

public class StudyArithmeticCalculations : MonoBehaviour
{
    // �Z�p���Z
    // �v�Z�̂���(�l�����Z)
    // PC�͓d�q�v�Z�@

    void Start()
    {
        int int01 = 10;
        float float01 = 1.0f;
        string string01 = "������";
        string string02 = "����";



        // �����Z
        int answer01 = 1 + 2; // 3
        // �����Z
        int answer02 = 1 - 2; // -1
        // �|���Z
        int answer03 = 1 * 2; // 2
        // ����Z
        int answer04 = 1 / 2; // 0 ��int�����Ȃ̂�0.5�Ƃ͂Ȃ�Ȃ�
        // �]�Z
        int answer05 = 1 % 2; // 1


        // �ϐ����܂߂��v�Z���ł���B
        int answer06 = answer01 + int01 + 2;

        // ��{�I�Ȑ��l�v�Z�Ɋւ��ẮA���w�Ɠ������[���ɏ]��
        int answer07 = 3 * (4 + 2) + 2 * 3; // 24


        // ����Ȍv�Z
        int answer08 = 0;
        answer08 += 3; // answer08 = answer08 + 3
        answer08 -= 3; // answer08 = answer08 - 3
        answer08 *= 3; // answer08 = answer08 * 3
        answer08 /= 3; // answer08 = answer08 / 3
        answer08 %= 3; // answer08 = answer08 % 3

        int answer09 = 0;
        // �C���N�������g
        answer09++; // answer09 = answer09 + 1
        // �f�N�������g
        answer09--; // answer09 = answer09 - 1


        // float �� int �Ɠ��l�Ɍv�Z�ł���B
        float answer10 = 1.0f + float01;

        // float �� int �̌v�Z�͒���
        float answer11 = float01 + int01;
        //int answer12 = float01 + int01;

        // string �͑����Z�̂݉\
        // �����񂪌�������
        string answer13 = string01 + string02;
        //string answer14 = string01 - string03;

        // bool �͎Z�p���Z�ł��Ȃ�
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
