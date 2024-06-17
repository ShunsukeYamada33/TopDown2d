using System.Collections.Generic;
using UnityEngine;

public class StudyNullConditionalOperator : MonoBehaviour
{
    // null �������Z�q null-conditional operator

    // null �Ȃ̂��m�F���Ă�����s���Ă����

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
        ������ resume01 = null;

        // �G���[�ɂȂ�B
        Debug.Log(resume01.Name);

        // null �̏ꍇ���s���Ȃ��̂ŃG���[�ɂȂ�̂�h����
        if (resume01 != null)
        {
            Debug.Log(resume01.Name);
        }

        // �ϐ��̉E�� ? ��t����
        Debug.Log(resume01?.Name);

        // ? ��t���邱�Ƃ� null ���m�F���Ă�����s���Ă����̂ŃG���[�ɂȂ�̂�h����B

        List<int> intList = null;
        // �ϐ��̉E�� ? ��t����
        // �C���f�b�N�X�̑O
        Debug.Log(intList?[0]);
    }
}
