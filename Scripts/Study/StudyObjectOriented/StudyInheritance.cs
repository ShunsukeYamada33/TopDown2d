using UnityEngine;

public class StudyInheritance : MonoBehaviour
{
    // �p�� Inheritance
    // �I�u�W�F�N�g�w���R�v�f

    // ����N���X�̃����o���A���̃N���X�Ɉ��p���i�p��������j�@�\
    // �p�����N���X�̐e�N���X(Super class)


    // �p���̂���
    // �p�����N���X(�e�N���X)
    private class Parent
    {
        public string name = "�e";
        public void ParentMethod()
        {
            Debug.Log("�e�̃��\�b�h");
        }
    }

    // �A�N�Z�X�C���q class ���O : �p�����N���X
    private class Child : Parent
    {
        private void ChildMethod()
        {
            // �e�̃t�B�[���h���g����
            Debug.Log(name);

            // �e�̃��\�b�h���g����
            ParentMethod();
        }
    }

    // �p���Ƃ͌p�����̃N���X�̋@�\���p����̃N���X�Ŏg�p�ł���悤�ɂ��邱��
    // Battler �퓬�ł���N���X
    // Player : Battler
    // Enemy : Battler
    // Warrior : Player
    // Wizard : Player
    // Thief : Player

    // ���鎞�AThief ������@�\���~�����ƂȂ�
    // Thief �ɓ����������
    // ����A������@�\�̎d�l�ύX
    // Player �������Ă��铦����@�\��ύX
    // Thief �̓�����@�\�����Ǝ��d�l�̂܂܂ƂȂ�o�O������

    // ���ӓ_
    // ���x���p���ł���B
    // �q�������ǂǂ̃N���X���p�����Ă���̂��킩��Ȃ��Ȃ�B
    // �����悤�ȃ��\�b�h�������������Ă���B
    // �o�O�̉����A�X�p�Q�b�e�B�R�[�h�̌���
}
