using UnityEngine;

public class StudyStatic : MonoBehaviour
{
    // Static �ÓI
    // �ÓI�N���X �ÓI�t�B�[���h �ÓI���\�b�h�̐錾�Ŏg���B

    // �A�N�Z�X�C���q static �^ ���O �̏�
    // static �͓�������啶���ɂ��������悢�B
    public static int Int;
    public static void Method01()
    {

    }

    // static class
    private static class Character
    {
        // static class �͑S�Ẵt�B�[���h�⃁�\�b�h�� static �ɂ���K�v������B
        public static int Status01 = 0;
        //public int status02;

        public static void Method01()
        {

        }

        // public void Method02() { }
    }

    private void Start()
    {
        // �g�p����ۂ͕ϐ����ł͂Ȃ� class�����璼�ړ���
        Debug.Log(Character.Status01);
        Character.Method01();

        // static class �͏������ł��Ȃ��B
        // Character character = new Character();
    }

    // ���ӓ_
    // static �ȃ��\�b�h�ł� static �ł͂Ȃ��t�B�[���h�𗘗p�ł��Ȃ��B
    public int int01;

    public static void Method02()
    {
        //Debug.Log(int01);
        int int02 = 0;
        Debug.Log(int02);
    }

    // �ǂ̃N���X����ł��A�N�Z�X�ł��Ă��܂�
    // �K�v�ȋ@�\���������J����Ƃ����J�v�Z�����̍l�����̋t
    // �I�u�W�F�N�g�w���I�ł͂Ȃ��̂Ŏg���Ƃ���͋C��t����K�v����B
}
