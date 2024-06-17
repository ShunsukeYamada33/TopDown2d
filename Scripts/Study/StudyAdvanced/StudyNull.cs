using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class StudyNull : MonoBehaviour
{
    // null

    // �v���O���~���O����ɂ����āu�����Ȃ��v�܂��́u���݂��Ȃ��v��Ԃ�\�����ʂȒl
    // �N���X�Ƃ͐݌v�}�A���g��
    // �C���X�^���X�Ƃ͎����A��

    private class ������
    {
        public string Name { get; }
        public string Description { get; }
        public string Type { get; }

        public ������(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
    }

    private void Method()
    {
        // ���̗������� null ����
        // ������ resume01;
        ������ resume02 = null;

        // �G���[�ɂȂ�Ȃ����A���s����ƃG���[�ɂȂ�
        Debug.Log(resume02.Name);

        // null �̏ꍇ���s���Ȃ��̂ŃG���[�ɂȂ�̂�h����
        if (resume02 != null)
        {
            Debug.Log(resume02.Name);
        }

        // �K��������(new)���悤�B
        ������ resume03 = new ������("Jhon", "�w��", "�j"); // ������
        Debug.Log(resume03.Name);


        List<int> list = null;
        Debug.Log(list[0]);
        // list = new();   �G���[�ɂȂ�Ȃ� 0 
        // list;           �G���[�ɂȂ�
        Debug.Log(list.Count);
    }
}
