using System.Collections.Generic;
using UnityEngine;

public class StudyDictionary : MonoBehaviour
{
    // Dictionary
    // ��ʂ̃f�[�^�������ꍇ�̎d�g�݂̈��
    // Key �ƌĂ΂�閼�O
    // Value �ƌĂ΂��l
    // Key �� Value ���Z�b�g�ň���
    // List�̓C���f�b�N�X�ƒl���Z�b�g����Dictionary��Key�̌^�͎��R
    // Key �̏d���͂��Ȃ�

    void Start()
    {
        Dictionary<string, int> keyValuePairs01 = new Dictionary<string, int>();
        Dictionary<string, int> keyValuePairs02 = new();
        Dictionary<string, int> keyValuePairs03 = new() { { "�R�c", 3 }, { "����", 4 } };



        // �g����
        keyValuePairs03["�R�c"] = 4;
        keyValuePairs03["����"] = 5;
        int answer = keyValuePairs03["�R�c"] + keyValuePairs03["����"];

        // ���݂��Ȃ�Key���w�肵�Ă͂����Ȃ��B
        // intList03["�c��"] = 3;

        // �v�f���̎擾
        int count = keyValuePairs03.Count;


        // ���̌^�ł��g�p�\
        Dictionary<int, string> intStringPair01 = new();
        Dictionary<float, float> floatFloatPair01 = new();
        Dictionary<bool, int> boolIntPair01 = new();

        //�v�f�̒ǉ�
        keyValuePairs01.Add("�܏\��", 4);
        keyValuePairs01.Add("���܎O", 5);

        //�v�f�̍폜
        //�l���w�肵�č폜
        keyValuePairs01.Remove("�܏\��");


        // �l�̌���
        bool isKey = keyValuePairs01.ContainsKey("���܎O");

        // ��
        // Dictionary �� Key �̏d����������Ă��Ȃ�
        // Add �� Key �����łɂ���ꍇ�̓G���[
        if (!keyValuePairs01.ContainsKey("���܎O"))
        {
            // Key �����݂��Ă��Ȃ��ꍇ�̂ݒǉ������ق����悢
            keyValuePairs01.Add("�܏\��", 4);
        }

        // Dictionary�̃N���A
        keyValuePairs01.Clear();

        // ���ɂ��@�\���������񂠂�̂ł�肽�����Ƃ��ł����璲�ׂ�Ȃ�!
    }
}
