using System.Collections.Generic;
using UnityEngine;

public class StudyList : MonoBehaviour
{
    // ���X�g
    // ��ʂ̃f�[�^�������ꍇ�̎d�g�݂̈��
    // �������̎��_�Ńf�[�^�̗v�f�������肷��K�v���Ȃ��B
    // �ォ�玩�R�ɗv�f����ς�����B

    void Start()
    {
        List<int> intList01 = new List<int>();
        List<int> intList02 = new();
        List<int> intList03 = new List<int>() { 1, 2, 3, 4 };
        List<int> intList04 = new() { 1, 2, 3, 4 };

        // �g����
        intList03[0] = 4;
        intList03[1] = 5;
        int answer = intList03[2] + intList03[3];

        // �v�f���𒴂���C���f�b�N�X���w�肵�Ă͂����Ȃ�
        // intList03[4] = 3;

        // �v�f���̎擾
        int count = intList03.Count;


        // ���̌^�ł��g�p�\
        List<float> floatList01 = new List<float>();
        List<string> stringList01 = new List<string>();
        List<bool> boolList01 = new List<bool>();

        //�v�f�̒ǉ�
        intList01.Add(3); // { 3 }
        intList01.Add(4); // { 3, 4 }

        //�v�f�̍폜
        //�l���w�肵�č폜
        intList01.Remove(3); // { 4 }

        // �C���f�b�N�X���w�肵�č폜
        // �v�f���𒴂���C���f�b�N�X���w�肵�Ă͂����Ȃ�
        intList01.RemoveAt(0); // { }

        // �l�̌���
        bool is3 = intList03.Contains(3);

        // ���X�g�̃N���A
        intList04.Clear(); // { }

        // ���ɂ��@�\���������񂠂�̂ł�肽�����Ƃ��ł����璲�ׂ�Ȃ�!
    }
}
