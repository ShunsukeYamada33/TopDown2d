using UnityEngine;

public class StudyMethod : MonoBehaviour
{
    // ���\�b�h�@�֐�
    // ���\�b�h�̍쐬�Ɨ��p


    // ��b
    // void ���\�b�h��()
    // {
    //   ����
    // }

    void Hello()
    {
        Debug.Log("����ɂ���");
    }

    void Log0to9()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
    }

    // �߂�l
    // �߂�l�̌^ ���\�b�h��()
    // {
    //   ����
    // }
    int Get10()
    {
        // �Ō�� return �Ŗ߂�l�̌^�Ɠ����l��Ԃ��B
        return 10;
    }

    // ����
    // �߂�l�̌^ ���\�b�h��(�����P�̌^ �����P, �����Q�̌^ �����Q, ....... , ����N�̌^ ����N)
    // {
    //   ����
    // }
    int GetSum(int x, int y)
    {
        // �����̒l���������ŗ��p�ł���B
        return x + y;
    }


    // Start()�����\�b�h
    void Start()
    {
        // ���\�b�h�̎g�p���@
        Hello();

        Log0to9();

        int x = Get10();
        int y = 5;
        int sun = GetSum(x, y);
    }
}
