using UnityEngine;

public class StudyWhile : MonoBehaviour
{
    // while
    // �J��Ԃ�����

    void Start()
    {
        int int01 = 0;

        // while ( ���� true, false )
        // {
        //    ����
        // }
        // �����𖞂����Ă������ �������J��Ԃ����s


        while (int01 < 10)
        {
            //����

            int01++;
        }
        // �����𖞂�����������菈�������s����̂� �����ɏ��������s���Ă��܂��\��������B
        // �������[�v �ɒ���

        do
        {
            //����
            int01++;
        } while (int01 < 10);
        // do while ��
        // while�Ƃ̈Ⴂ�� do while �͍ŏ��̂P��͕K������������B
    }
}
