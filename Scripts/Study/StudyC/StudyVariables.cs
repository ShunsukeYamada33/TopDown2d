using UnityEngine;

public class StudyVariables : MonoBehaviour
{
    // �ϐ�

    // �l��ۑ����Ă������ꕨ�̂���
    // ��������ނ�����
    // �����A�����A������A�^�U

    void Start()
    {
        // �^ ���O�i��{�I�Ɏ��R) ;
        int variable = 0;


        // ���� 0, 1, -1
        int int01 = 0;

        // ���� 0f, 0.0f, 1.0f, -1.0f
        float float01 = 0.0f;

        // ������ "", "����������", "String", "Hello World!"
        string string01 = "";

        // �^�U true, false
        bool bool01 = false;

        // = �̖����� �E�̒l�����ɑ������
        int01 = 10;
        float01 = 10.0f;
        string01 = "�͂�[";
        bool01 = true;
        // ���� �^ �ɂ�������ł��Ȃ��B

        // �Ⴄ �^ �ɂ���悤�Ƃ���Ɗ�{�I�ɃG���[�ɂȂ�
        //int01 = float01;

        Debug.Log(variable);
        Debug.Log(int01);
        Debug.Log(float01);
        Debug.Log(string01);
        Debug.Log(bool01);
        Debug.Log(string01);
    }
}
