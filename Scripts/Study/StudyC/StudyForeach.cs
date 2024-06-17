using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyForeach : MonoBehaviour
{
    // foreach
    // �z��AList�ADictionary�𗘗p�����J��Ԃ�����

    void Start()
    {
        List<int> intList01 = new() { 3, 4, 5, 6 };

        // foreach ( �^ �ϐ��� in ���X�g��)
        // {
        //    ����
        // }

        int sum01 = 0;
        foreach (int integer in intList01)
        {
            sum01 += integer;
        }

        // ���X�g���������o���ď������ł���B
        // ���X�g�𑀍삷��ۂɃC���f�b�N�X�̈������ԈႦ��ƃG���[�ɂȂ邪�A
        // foreach�͂��̐S�z���Ȃ��B

        // List�ɃC���f�b�N�X���w�肵�Ď擾����̂͊�{�g��Ȃ��B

        // for �𗘗p�����L�q���ł���B
        int sum02 = 0;
        for (int i = 0; i < intList01.Count; i++)
        {
            sum02 += intList01[i];
        }



        int[] ints = { 3, 4, 5, 6, };
        int sum03 = 0;
        foreach (int integer in ints)
        {
            sum03 += integer;
        }

        // Dictionary�͉��p
        Dictionary<string, int> keyValuePairs = new() { { "�R�c", 3 }, { "�c��", 5 } };
        int sum04 = 0;
        foreach (KeyValuePair<string, int> keyValuePair in keyValuePairs)
        {
            sum04 += keyValuePair.Value;
        }
    }
}
