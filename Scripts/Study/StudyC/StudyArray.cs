using UnityEngine;

public class StudyArray : MonoBehaviour
{
    // �z��
    // ��ʂ̃f�[�^�������ꍇ�̎d�g�݂̈��
    // �������̎��_�Ńf�[�^�̗v�f�������肷��K�v������B

    void Start()
    {
        // �^[] ���O = new �^[�C���f�b�N�X(�Y��)�ƌĂ΂�鐮��];
        int[] ints01 = new int[4];
        int[] ints02 = { 1, 2, 3, 5 };

        // �g����
        // 0����n�܂�
        ints01[0] = 1;
        ints01[1] = 2;
        int answer = ints01[2] + ints01[3];
        // �v�f���𒴂���C���f�b�N�X���w�肵�Ă͂����Ȃ�
        // ints01[4] = 5;

        // ����Ȏg����
        // �v�f�����擾����
        int length = ints01.Length;

        // ���̌^�ł��g�p�\
        float[] floats = new float[4];
        string[] strings = new string[4];
        bool[] bools = new bool[4];

        Debug.Log(answer);
        Debug.Log(floats);
        Debug.Log(strings);
        Debug.Log(bools);
        Debug.Log(length);
    }
}
