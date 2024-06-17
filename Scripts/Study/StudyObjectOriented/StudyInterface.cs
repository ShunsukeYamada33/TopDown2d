using UnityEngine;

public class StudyInterface : MonoBehaviour
{
    // interface �C���^�t�F�[�X

    // ���{��� ���E�ʁA�ڑ������A���ʋ���

    // �N���X�̓t�B�[���h�A�v���p�e�B�A���\�b�h���������\
    // �C���^�t�F�[�X�̓v���p�e�B�ƃ��\�b�h�̌^�Ɩ��O������錾
    // �ł��邱�Ƃ�錾���āA��邱�Ƃ͖�����


    // ����
    // �A�N�Z�X�C���q interface ���O(��������I��t����̂��悢)
    private interface ICharacter
    {
        // �v���p�e�B
        string Name { get; }
        int Health { get; }
        int PhysicAttack { get; }
        int MagicAttack { get; }

        // ���\�b�h
        // �������Ȃ��̂�{}�͏ȗ����� ; �ŏI���
        void Attack(ICharacter target);
        void TakeDamage(int damage);
    }


    private class Warrior : ICharacter
    {
        // �C���^�t�F�[�X�����v���p�e�B�⃁�\�b�h�͕K����������K�v������B
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        public void Attack(ICharacter target)
        {
            // ��m�͕����U���͂��_���[�W�Ƃ���
            target.TakeDamage(PhysicAttack);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    private class Wizard : ICharacter
    {
        // �C���^�t�F�[�X�����v���p�e�B�⃁�\�b�h�͕K����������K�v������B
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        public void Attack(ICharacter target)
        {
            // ���@�g���͖��@�U���͂��_���[�W�Ƃ���
            target.TakeDamage(MagicAttack);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    // �C���^�t�F�[�X�𗘗p���ċ����I�ɃN���X�̋@�\�𐧌��ł���
    // �]�v�ȃ����o�ւ̃A�N�Z�X�̐����������邱�Ƃ��ł��A�o�O�̔�����}���ł���B
    // �e��q���ō��ꂽ�N���X�֊Ԉ�������@�ŃA�N�Z�X�����댯����������B
    // �����悤�ȃ��\�b�h�̗�����h����

    // �C���^�t�F�[�X�𗘗p�����p������������

    // ���ӓ_
    // TakeDamage���\�b�h�ł͓������������x���L�q����K�v������B
    // �d�l�ύX�őS�ĘR�ꂸ�ɏC������K�v������B
}
