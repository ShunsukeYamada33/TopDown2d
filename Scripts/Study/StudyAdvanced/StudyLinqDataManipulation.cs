using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinqDataManipulation : MonoBehaviour
{
    // LINQ �f�[�^�̑���
    // take      �ŏ���n�̗v�f�ɍi��
    // skip      �ŏ���n�̗v�f�̓X�L�b�v
    // distinct  �d�����Ȃ���

    List<int> intList = new() { 1, 6, 4, 1, 4, 3 };

    private void Start()
    {
        // �ŏ���n�̗v�f�ɍi��
        var take = intList.OrderBy(i => i).Take(3);
        foreach (int i in take)
        {
            Debug.Log(i);
        }

        // 1, 1, 3

        // �ŏ���n�̗v�f�̓X�L�b�v
        var skip = intList.OrderBy(i => i).Skip(3);
        foreach (int i in skip)
        {
            Debug.Log(i);
        }

        // 4, 4, 6

        // �ŏ���n�̗v�f�̓X�L�b�v
        var distinct = intList.Distinct();
        foreach (int i in distinct)
        {
            Debug.Log(i);
        }

        // 1, 6, 4, 3
    }
}
