using System;
using UnityEngine;

public class StudyAction : MonoBehaviour
{
    // �f���Q�[�g��Action

    // ��`�ς̃f���Q�[�g
    // �錾������K�v���Ȃ��f���Q�[�g�̂���
    // Action �͖߂�l�̂Ȃ���`�ς݂̃f���Q�[�g�̂���

    private void MainMethod()
    {
        // �ȗ��ł���
        // private delegate void Action();
        Action action01 = Method01;

        // ����������\
        // Action<�����P, ......>
        Action<string> action02 = Method02;
        Action<string, string> action03 = Method03;

        action01.Invoke();
        action02.Invoke("�A�N�V����");
        action03.Invoke("�A�N�V����01", "�A�N�V����02");


        // �����_���g�p�ł���
        Action action04 = () => Debug.Log("�ǉ��A�N�V����");
        // ���\�b�h�̒ǉ�
        action04 += Method01;

        action04.Invoke();
    }

    private void Method01()
    {
        Debug.Log("�A�N�V����");
    }

    private void Method02(string text)
    {
        Debug.Log(text);
    }

    private void Method03(string text01, string text02)
    {
        Debug.Log(text01 + text02);
    }
}
