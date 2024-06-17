using UnityEngine;

public class StudyConstructor : MonoBehaviour
{
    // constructor �R���X�g���N�^�[
    // �C���X�^���X������ۂɎ��s����鏈���̂���
    // ��{�I�� private �ȃt�B�[���h�� readonly �ȃt�B�[���h�̏������ɗ��p�����

    private class Character
    {
        // private �ȃt�B�[���h�̏�����
        // readonly �ȃ��\�b�h�̏��������ł���
        private readonly string _name;

        // �Z�b�g�Ńv���p�e�B���p�ӂ���Ƃ悢
        public string Name { get => _name; }

        // �R���X�g���N�^
        // class���Ɠ������O�̃��\�b�h�悤�ȋL�q (�߂�l�̌^�͂Ȃ�)
        public Character()
        {
            _name = "���E";
        }

        // ������ǉ��ł���B
        // ������ς��ăR���X�g���N�^�͕�������
        public Character(string name)
        {
            _name = name;
        }
    }

    private void Start()
    {
        // �R���X�g���N�^�𗘗p�����C���X�^���X��
        Character none = new Character();
        Character warrior = new Character("��m");
        Character wizard = new Character("���@�g��");

        Debug.Log(none.Name);
        Debug.Log(warrior.Name);
        Debug.Log(wizard.Name);

        // �R���X�g���N�^�𗘗p���邱�Ƃ�
        // �������ȍ~�Œl�̕ύX���ł��Ȃ��ł���
        // �l��ݒ�ł���^�C�~���O�𔛂�Ƃ����J�v�Z����
    }
}
