using UnityEngine;

public class StudyClass : MonoBehaviour
{
    // �N���X
    // ���\�b�h�ƃt�B�[���h���܂Ƃ߂ē���̋@�\����������
    // �^


    // �Ⴆ�΂��̃N���X���v���C���[��\���N���X
    string playerName;
    int health;
    int attack;

    // class ���^�Ȃ̂ň�����߂�l�̌^�Ƃ��Ďg�p�ł���B
    void Attack(StudyClass target)
    {
        // target �ɍU�����鏈��
        target.TakeDamage(attack);
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(playerName + "��" + damage + "�̃_���[�W���󂯂�");
    }

    void Start()
    {
        // class �͌^�Ȃ̂ŏ��������ĕϐ��Ƃ��ė��p�ł���B
        StudyClass character = new StudyClass();
        StudyClass target = new();

        // character �� target �ɍU�����鏈��
        character.Attack(target);
    }
}
