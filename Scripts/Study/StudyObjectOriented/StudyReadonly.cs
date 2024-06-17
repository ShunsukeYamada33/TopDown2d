using System.Collections.Generic;
using UnityEngine;

public class StudyReadonly : MonoBehaviour
{
    // readonly
    // ���������s�\�ȃt�B�[���h���쐬�ł���

    // �A�N�Z�X�C���q�@readonly �^ ���O
    private readonly int _int = 0;

    private void Method01()
    {
        // ���̒l�������悤�Ƃ���ƃG���[�ɂȂ�悤�ɂȂ�B
        // _int01 = 2;
        Debug.Log(_int);
    }

    // static ��t����ꍇ
    // �A�N�Z�X�C���q static readonly �^ ���O
    private static readonly int Int = 0;

    // class, �z��, List, Dictionary ���ł��g����
    private readonly Character _character = new();
    private readonly List<int> _intList = new();

    private void Method02()
    {
        // readonly class �̃t�B�[���h�̒l��ς��邱�Ƃ͂ł���B
        _character.name = "��m";

        // �V���� class �̑���͕s��
        // _character = new();

        // List�̗v�f�̒ǉ�, �v�f�̒l�̕ύX�Ȃǂ͂ł���
        _intList.Add(Int);
        _intList[0] = 3;

        // �V���� List �̑���͕s��
        // _intList = new();

        // �����܂ł����̃C���X�^���X�����v�f�͕ς����邪�A���̂��͕̂ς����Ȃ�
    }


    private class Character
    {
        public string name;
    }
}
