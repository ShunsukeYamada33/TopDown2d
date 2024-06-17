using System.Security.Principal;
using System;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class StudyDelegation : MonoBehaviour
{
    // �Ϗ�(�C����) Delegation
    // �@�\�̈ꕔ�𑼂̃N���X�ɔC����

    // �L�����N�^�[�̃C���^�[�t�F�[�X���p������ ��m ���@�g�� ���l����
    // �_���[�W���󂯂鏈���͋��ʂȂ̂ő��̃N���X�ɔC����


    // �L�����N�^�[��p������
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }
        int PhysicAttack { get; set; }
        int MagicAttack { get; set; }

        void Attack(ICharacter target);
        void TakeDamage(int damage);
    }

    // �Ϗ��p�̃N���X(�_���[�W���󂯂鏈����C����)
    private class TakeDamageDelegation
    {
        // �C���Ă���C���^�[�t�F�[�X�����B
        private readonly ICharacter _character;

        // �R���X�g���N�^�Őݒ�
        public TakeDamageDelegation(ICharacter character)
        {
            _character = character;
        }

        public void TakeDamage(int damage)
        {
            _character.Health -= damage;
        }
    }


    private class Warrior : ICharacter
    {
        // �C���^�t�F�[�X�����v���p�e�B�⃁�\�b�h�͕K����������K�v������B
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        private readonly TakeDamageDelegation _takeDamage;

        public Warrior()
        {
            _takeDamage = new TakeDamageDelegation(this);
        }

        public void Attack(ICharacter target)
        {
            // ��m�͕����U���͂��_���[�W�Ƃ���
            target.TakeDamage(PhysicAttack);
        }

        public void TakeDamage(int damage)
        {
            _takeDamage.TakeDamage(damage);
        }
    }

    private class Wizard : ICharacter
    {
        // �C���^�t�F�[�X�����v���p�e�B�⃁�\�b�h�͕K����������K�v������B
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        private TakeDamageDelegation _takeDamage;

        public Wizard()
        {
            _takeDamage = new TakeDamageDelegation(this);
        }

        public void Attack(ICharacter target)
        {
            // ���@�g���͖��@�U���͂��_���[�W�Ƃ���
            target.TakeDamage(MagicAttack);
        }

        public void TakeDamage(int damage)
        {
            _takeDamage.TakeDamage(damage);
        }
    }

    // �V�����N���X���쐬����Ă�
    // �������� ��m ���@�g�� �N���X�̋L�q��������
    // ��₱����

    // TakeDamageDelegation�N���X��TakeDamage���\�b�h���ύX���ꂽ�Ƃ���
    // �ύX����ꏊ��1�����ōς�

    // ���ʂ̏��������x���L�q���Ȃ��čς�
    // ���ʂ̏������ύX���ꂽ�Ƃ��ɏC���ӏ����P�����ōς�


    // �C���^�[�t�F�[�X�̌p���ƈϏ������Ɏg�����Ȃ���
    // 
}
