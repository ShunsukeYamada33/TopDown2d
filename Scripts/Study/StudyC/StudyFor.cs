using UnityEngine;

public class StudyFor : MonoBehaviour
{
    // For
    // �J��Ԃ�����

    void Start()
    {
        // for ( �����l ; ���� ; ��������)
        // {
        //    ����
        // }

        int sum01 = 0;
        for(int i = 0; i < 10; i++)
        {
            //����
            sum01 += i;
        }
        // i �̍��v�����߂�


        // �����̗���
        // �@������ int i = 0
        // �A�����̊m�F i < 10
        // �B����
        // �C�������� i++
        // �D�����̊m�F
        // �ȗ�
        // ������ false �ɂȂ��Ă�����I��

        // �����l�A�����A�����������P�s�ɋL�ڂł���̂� while �����������[�v�ɂȂ�ɂ���
        // �������[�v�ɒ���


        // ��
        int sum02 = 0;
        for(int i = 10; i > 0; i--)
        {
            // ����
            sum02 += i;
        }

        int sum03 = 0;
        for (int i = 0; i < 10; i += 3)
        {
            // ����
            sum03 += i;
        }
    }
}
