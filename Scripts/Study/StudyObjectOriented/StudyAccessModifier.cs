using UnityEngine;

public class StudyAccessModifier : MonoBehaviour
{
    // �A�N�Z�X�C���q
    // �ǂ̃t�B�[���h�⃁�\�b�h�𑼂̕��Ɍ��J���邩�錾�������

    public class Character
    {
        // �v���C�x�[�g
        // ���̃I�u�W�F�N�g�Ɍ��J���Ȃ��B
        // ���g�� class ���݂̂ő���ł���B
        // �ȗ��\
        // �������� "_" ��t����̂��悢
        int _privateInt01 = 0;
        private int _privateInt02 = 0;

        // �p�u���b�N
        // ���̃I�u�W�F�N�g�Ɍ��J
        // ���� class �ő��삪�ł���
        public int publicInt = 0;

        // Unity��p
        // ���̃I�u�W�F�N�g�Ɍ��J���Ȃ��B
        // ���g�� class ���݂̂ő���ł���B
        // ������ Unity Editor �ő���ł���B
        [SerializeField] private int serializeFieldInt = 0;

        private void privateMethod()
        {
            // ���g�� class �����ƑS�Ďg�p�\
            Debug.Log(_privateInt01);
            Debug.Log(_privateInt02);
            Debug.Log(publicInt);
            Debug.Log(serializeFieldInt);
        }

        public void publicMethod()
        {
            privateMethod();
        }
    }

    private void Start()
    {
        Character character = new Character();

        // public �̃A�N�Z�X�C���q��t�������̂̂݃A�N�Z�X�ł���B
        //character.privateInt01 = 0;
        //character.privateInt02 = 0;
        character.publicInt = 0;
        //character.serializeFieldInt = 0;

        // ���\�b�h�����l�� public �̂݃A�N�Z�X�\
        //character.privateMethod();
        character.publicMethod();
    }
}
