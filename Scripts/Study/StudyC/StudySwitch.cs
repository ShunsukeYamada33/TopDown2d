using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    // Switch
    // ��������

    void Start()
    {
        int int01 = 0;

        // switch ( �ϐ� )
        // {
        //   case �l:
        //      ����
        //      break;
        //   default:
        //      ����
        //      break;
        // }

        // �ϐ��� case ��̒l���������ꍇ�ɂ��̏��������s
        switch (int01)
        {
            case 0:
                //�����@
                break;
            case 1:
                //�����A
                break;
            case 2:
                //�����B
                break;
            default:
                //�����C
                break;
        }


        // if���𗘗p���ē��l�ɋL�q�ł���B
        if (int01 == 0)
        {
            // �����@
        }
        else if (int01 == 1)
        {
            // �����A
        }
        else if (int01 == 2)
        {
            // �����B
        }
        else
        {
            // �����C
        }

        // default �� if���� else �悤�Ȃ��̂łǂ� case �ɂ��������Ȃ��ꍇ�ɏ��������s����B



        // break��t���Ȃ��ꍇ�͏������I�������Ɏ��� case ���m�F����
        switch (int01)
        {
            case 0:
                //�����@
            case 1:
                //�����A
                break;
            case 2:
                //�����B
                break;
        }

        // int01 �� 0 �̏ꍇ�� �����@�Ə����A�����s
        // int01 �� 1 �̏ꍇ�� �����A�����s
        // int01 �� 2 �̏ꍇ�� �����B�����s

        // �Ӑ}�I�ł͂Ȃ��ꍇ�� break ��Y��Ă��G���[�ɂȂ�Ȃ��̂Œ���
    }
}
