using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinqOrderby : MonoBehaviour
{
    // LINQ ���ёւ�
    // OrderBy              ���� ���񂾂�傫���Ȃ�悤�ɕ��ׂ�
    // OrderByDescending    �~�� ���񂾂񏬂����Ȃ�悤�ɕ��ׂ�

    List<int> intList = new() { 1, 6, 5, 2, 4, 3 };

    private void Start()
    {
        // �����ɕ��בւ���
        var listOrderBy = intList.OrderBy(i => i);
        foreach (var i in listOrderBy)
        {
            Debug.Log(i);
        }

        // 1, 2, 3, 4, 5, 6

        var listOrderByDescending = intList.OrderByDescending(i => i);
        foreach(var i in listOrderByDescending)
        {
            Debug.Log(i);
        }

        // 6, 5, 4, 3, 2, 1

        // ����������בւ�����Ba-z


        // ���̃��X�g���ς�����킯�ł͂Ȃ��B
    }
}
