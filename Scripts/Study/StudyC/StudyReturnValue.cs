using UnityEngine;

public class StudyReturnValue : MonoBehaviour
{
    // �߂�l return void
    // ���\�b�h�͎��s���ʂ�Ԃ����Ƃ��ł���B

    // �߂�l ���\�b�h�̎��s���ʂ̂���
    // return ���\�b�h�̍Ō�ɒl��Ԃ������B
    // value ���s���ʂ��Ȃ����Ƃ�\���^

    // �߂�l�̌^ ���\�b�h��()
    int ReturnInt()
    {
        // return �l;
        return 0;
    }

    string ReturnString()
    {
        return "����ɂ���";
    }

    // void �߂�l���Ȃ�
    // return �g���Ȃ��B
    void NoReturnValue()
    {
        //return 0;
        //return "����ɂ���";
    }

    void Start()
    {
        // �߂�l�̎󂯎���
        int int01 = ReturnInt();
        Debug.Log(int01);

        string string01 = ReturnString();
        Debug.Log(string01);

        NoReturnValue();

        // �߂�l���󂯎��Ȃ����Ƃ��\
        ReturnInt();
    }
}
