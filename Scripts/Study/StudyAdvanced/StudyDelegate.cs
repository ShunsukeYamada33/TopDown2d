using UnityEngine;

public class StudyDelegate : MonoBehaviour
{
    // �f���Q�[�g delegate ��\��

    // �������s�����ɁA���ڃ��\�b�h���ĂԂ̂ł͂Ȃ��A��\�҂��Ă�


    // �A�N�Z�X�C���q delegate �ߒl�̌^ �f���Q�[�g�� ( �����P�̌^, ......)
    private delegate void MyDelegate();

    private void MainMethod()
    {
        // �錾
        // �ȗ��n������ ��ʂɂ͏ȗ��`����������Ă��܂��B
        // MyDelegate myDelegate01 = new MyDelegate(Method01);
        MyDelegate myDelegate02 = Method01;

        // �Ăяo��
        // �f���Q�[�g�̌Ăяo�����Ƃ킩��₷���̂� Invoke �ŌĂԂ̂���ʓI
        // myDelegate02();
        myDelegate02.Invoke();

        // �������Ƃ��ł���B
        myDelegate02 += Method02;
        // �������Ƃ��ł���B
        myDelegate02 -= Method01;

        // �߂�l������̌^����v���Ă��Ȃ��ƃ_��
        // MyDelegate myDelegate03 = Method03;
        // MyDelegate myDelegate04 = Method04;
        IntDelegate01 intDelegate01 = Method03;
        IntDelegate02 intDelegate02 = Method04;
    }


    private void Method01()
    {
        Debug.Log("���s01");
    }

    private void Method02()
    {
        Debug.Log("���s02");
    }

    private int Method03()
    {
        return 0;
    }

    private void Method04(int i)
    {
        Debug.Log(i);
    }

    private delegate int IntDelegate01();
    private delegate void IntDelegate02(int i);
}
