using UnityEngine;

public class StudyPolymorphism : MonoBehaviour
{
    // �|�����[�t�B�Y�� polymorphism ���l��
    // �I�u�W�F�N�g�w���R�v�f

    // �L�����N�^�[�����܂��B
    // ��m�̃L�����N�^�[�A���@�g���̃L�����N�^�[�A�����̃L�����N�^�[ ���l��������
    // �������ł��邱�Ƃ��Ⴄ�Ƃ���B

    // �L�����N�^�[��p������
    private class Character
    {
        public string name;
        public int health;
        public int physicAttack;
        public int magicAttack;
        public void Attack(Character target)
        {
            target.TakeDamage(physicAttack);
        }
        public void TakeDamage(int damage) { }
    }

    private class Warrior : Character
    {
    }

    private class Wizard : Character
    {
        // public void Attack(Character target)
        // {
        //     ���@�g���� magicAttack �ōU��
        //     target.TakeDamage(magicAttack);
        // }
    }

    // ���̗�������ς��邾���� Wizard�N���X��Attack���\�b�h������������@����܂��B
    // �I�[�o�[���C�h override

    // ���̍u���ł͔񐄏��Ƃ������ƂŒm�肽�����͒��ׂĂ��������B
}
