using UnityEngine;

public class StudyField : MonoBehaviour
{
    // �t�B�[���h �X�R�[�v ���[�J���ϐ� �O���[�o���ϐ�
    // �t�B�[���h ���\�b�h�O�̕ϐ��̂���
    // �X�R�[�v �ϐ����e����^����͈́A�L�������͈�
    // �O���[�o���ϐ� �ǂ��ł����p�ł���ϐ�
    // ���[�J���ϐ� ����͈͓̔��ŗ��p�����ϐ�

    // �t�B�[���h��
    int field01 = 0;
    string field02 = "����ɂ���";
    // �t�B�[���h�͑S�Ẵ��\�b�h�ŗ��p�ł���B

    void Method01()
    {
        int int01 = 10;
        Debug.Log(int01);
        Debug.Log(field01);
    }

    void Start()
    {
        // �t�B�[���h�𗘗p�ł���
        int answer01 = field01 + 1;
        Debug.Log(answer01);
        Debug.Log(field02);

        // ���̃��\�b�h�̕ϐ��͗��p�ł��Ȃ�
        //int answer02 = int01 + 1;

        // �X�R�[�v
        for (int i = 0; i < 10; i++)
        {
            int int02 = 0;
            Debug.Log(int02);
        }

        // if for while switch foreach �Ȃǂ� {} �Ő錾�����ϐ������p�ł��Ȃ��B
        // int answer03 = int02 + 1;

        // ��̋L�ڂ̂悤�ɗ��p�ł���͈͂�����B
        // ���͈̔͂����̕ϐ��� "�X�R�[�v" �ƌ����B
        // �t�B�[���h�͑S�Ẵ��\�b�h�ŗ��p�ł���̂� "�O���[�o���ϐ�" �ƌ����B
        // ���\�b�h���̕ϐ��͗��p�ł���͈͂�����̂� "���[�J���ϐ�" �ƌ����B
    }
}
