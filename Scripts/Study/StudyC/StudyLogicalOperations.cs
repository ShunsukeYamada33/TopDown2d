using UnityEngine;

public class StudyLogicalOperations : MonoBehaviour
{
    // �_�����Z
    // bool �������ƂȂ�v�Z���@02

    void Start()
    {
        // && �_���� AND
        // ���� true ���� �E�� true �Ȃ�� true�A����ȊO�� false
        bool answer01 = true && true; // true
        bool answer02 = true && false; // false
        bool answer03 = false && false; // false

        // || �_���a OR
        // ���� true �܂��� �E�� true �Ȃ�� true, ����ȊO�� false
        bool answer04 = true || true; // true
        bool answer05 = true || false; // true
        bool answer06 = false || false; // false

        // ! �ے� NOT
        bool answer07 = !true; // false
        bool answer08 = !false; // true

        // ���H
        int int01 = 10;
        int int02 = 20;
        bool answer09 = (int01 > 15) || (int02 > 15);
        bool answer10 = (int01 > 3) && (int01 <= 5) || !(int02 <= 6);

        // �v�Z�̗D�揇��
        // () �J�b�R���̌v�Z
        // ++ -- �C���N�������g�A�f�N�������g
        // */% �|�Z�Ɗ��Z�Ɨ]�Z
        // +- ���Z�ƈ��Z
        // ��r���Z
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
