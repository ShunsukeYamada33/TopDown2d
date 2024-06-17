using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinqWhere : MonoBehaviour
{
    // LINQ �t�B���^�����O�n�@�\
    // Where
    // ����̏����Ń��X�g�̏��Ȃǂ��i��

    int[] ints = { 1, 2, 3, 4, 5, 6 };
    List<int> intList = new() { 1, 2, 3, 4, 5, 6 };
    Dictionary<int, int> intDictionary = new() { { 1, 10 }, { 2, 10 } };

    private void Start()
    {
        // 2�̗]�肪0�Ȃ��̂����Ƀt�B���^�����O
        // 2�̔{���Ƀt�B���^�����O
        var newIntList = intList.Where(i => i % 2 == 0);
        foreach (var i in newIntList)
        {
            Debug.Log(i);
        }

        // 2, 4, 6


        // LINQ ���g��Ȃ���
        var list = new List<int>();
        foreach (var i in intList)
        {
            if (i % 2 == 0)
            {
                list.Add(i);
            }
        }

        foreach (var i in list)
        {
            Debug.Log(i);
        }


        var newInts = ints.Where(i => i % 2 == 0);

        foreach (var i in newInts)
        {
            Debug.Log(i);
        }
        
        // 2, 4, 6

        var newIntDictionary = intDictionary.Where(i => i.Key % 2 == 0);
        foreach (var i in newIntDictionary)
        {
            Debug.Log(i.Value);
        }

        // 10


        // ���̃��X�g���ς�����킯�ł͂Ȃ��B
    }
}
