using UnityEngine;

public class StudyEncapsulate : MonoBehaviour
{
    // �J�v�Z����
    // �I�u�W�F�N�g�w���R�v�f

    // ���̃I�u�W�F�N�g�ɕK�v�ȋ@�\���������J���邱��
    // �s�v�ȋ@�\�͌��J���Ȃ�����
    // ���̃I�u�W�F�N�g����s�v�ȏ���������邱�ƂŔ�������o�O��h��

    // �L�����N�^�[
    public class Character
    {
        string characterName;
        int health;
        int attack;

        void Attack(Character character)
        {
            // �U���̏���
            character.TakeDamage(attack);
        }

        void TakeDamage(int damage)
        {
            health -= damage;
            Debug.Log(characterName + "�̍U��" + damage + "�̃_���[�W�B");
        }
    }

    // characterName �𑼂̃I�u�W�F�N�g�ɏ���������ꂽ��ʐl�c�c
    // health �𑼂̃I�u�W�F�N�g�ɏ����������Ă��̂܂ɂ����S���Ă���c�c
    // attack �𑼂̃I�u�W�F�N�g�ɏ��������ꂽ�炢�̂܂ɂ��ŋ��A�Ŏ�Ɂc�c
    // TakeDamage() �����x�����s����Ă��̂܂ɂ����S���Ă���c�c
    
    // ���̃L�����N�^�[�ɍU�����鏈���͌��J���Ă��悢
}
