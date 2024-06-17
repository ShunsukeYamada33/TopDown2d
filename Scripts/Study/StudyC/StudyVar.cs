using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StudyVar : MonoBehaviour
{
    // var �^���_
    // �ÖٓI�^�w�胍�[�J���ϐ�

    void Start()
    {
        // �����ŏ���������Ǝ����I�� int
        var int01 = 0;
        // ���l�̖����� f ��t����Ǝ����I�� float
        var float01 = 0.0f;
        // "" �ň͂ނƎ����I�� string
        var string01 = "����ɂ���";
        // true �܂��� false ���Ǝ����I�� bool
        var bool01 = false;

        var intList = new List<int>();
        var keyValuePairs = new Dictionary<string, string>();

        // �����b�g
        // var �Ƃ����R�����ŌŒ肳���̂ŕϐ��������₷��
        // foreach �� for �Ƃ������ۂ̏��������y( KeyValuePair<string, string> )
        foreach (var keyValue in keyValuePairs)
        {
            Debug.Log(keyValue.Key);
        }

        // �f�����b�g
        // �^�������킩��ɂ���
        var int02 = int01;
        var float02 = float01;
        var string02 = string01;
        var bool02 = bool01;
        var list = GetList();

        Debug.Log(int02);
        Debug.Log(float02);
        Debug.Log(string02);
        Debug.Log(bool02);
        Debug.Log(list);
    }

    // �t�B�[���h(�O���[�o���ϐ�)�ɂ͎g�p�ł��Ȃ��B
    // ���[�J���ϐ��̂� var ���g�p�\
    // var int02 = 0;




    private List<bool> GetList()
    {
        var list = new List<bool>();
        return list;
    }
}
