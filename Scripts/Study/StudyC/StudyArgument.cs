using UnityEngine;

public class StudyArgument : MonoBehaviour
{
    // ���� argument
    // ���� ���\�b�h�ɑ΂��ē��͂���l�̂���

    // �߂�l�̌^ ���\�b�h��(�����P�̌^�@�����P�̕ϐ���, �����Q�̌^�@�����Q�̕ϐ���, ..... ����N�̌^�@����N�̕ϐ���) 
    void Sum(int int01, int int02)
    {
        int answer = int01 + int02;
        Debug.Log(answer);
    }

    void LogNameAndAge(string name, int age)
    {
        Debug.Log("���O:" + name + " �N��: " + age + "��");
    }


    void Start()
    {
        // ������ݒ肵�����\�b�h�̎��s
        // ���s���ɂ͌^�͕s�v�B
        Sum(1, 2);
        LogNameAndAge("�R�c", 3);

        // �����Ƃ��ė^�����l�̌^���قȂ�ƃG���[
        // LogNameAndAge(1, 3);
    }
}
