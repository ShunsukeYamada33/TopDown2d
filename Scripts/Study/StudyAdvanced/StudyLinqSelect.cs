using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinqSelect : MonoBehaviour
{
    // LINQ �f�[�^�̕ϊ�
    // Select

    List<int> intList = new() { 1, 6, 5, 2, 4, 3 };

    private void Start()
    {
        // �S�Ă̗v�f���R�{����
        var listSelect = intList.Select(i => i * 3);
        foreach (var i in listSelect)
        {
            Debug.Log(i);
        }

        // 3, 18, 15, 6, 12, 9

        // 3�ȉ��Ƀt�B���^�����O
        // �v�f��3�{
        var list = intList.Where(i => i <= 3).Select(i => i * 3);
        foreach (var i in list)
        {
            Debug.Log(i);
        }

        // 3, 6, 9


        // ���̃��X�g���ς�����킯�ł͂Ȃ��B
    }
}
