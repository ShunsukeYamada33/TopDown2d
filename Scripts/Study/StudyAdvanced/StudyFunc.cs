using System;
using UnityEngine;

public class StudyFunc : MonoBehaviour
{
    // �f���Q�[�g��Func

    // ��`�ς̃f���Q�[�g
    // �錾������K�v���Ȃ��f���Q�[�g�̂���
    // Func �͖߂�l�̂����`�ς݂̃f���Q�[�g�̂���

    private void MainMethod()
    {
        // �ȗ��ł���
        // private delegate �^ Func();
        Func<string> action01 = Method01;

        // ����������\
        // Action<�����P, ......., �߂�l�̌^>
        Func<int, string> action02 = Method02;
        Func<int, int, string> action03 = Method03;

        string answer01 = action01.Invoke();
        string answer02 = action02.Invoke(0);
        string answer03 = action03.Invoke(0, 1);


        // �����_���g�p�ł���
        Func<string> action04 = () => { return "�ǉ��A�N�V����"; };
        // ���\�b�h�̒ǉ�
        action04 += Method01;

        action04.Invoke();
    }

    private string Method01()
    {
        return "�t�@���N";
    }

    private string Method02(int score)
    {
        return "�X�R�A��" + score;
    }

    private string Method03(int score01, int score02)
    {
        var sum = score01 + score02;
        return "�X�R�A��" + sum;
    }
}
