using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinTotalling : MonoBehaviour
{
    // LINQ �f�[�^�̏W�v
    // sum     ���v
    // average ����
    // count   �J�E���g
    // max     �ő�
    // min     �ŏ�

    List<int> intList = new() { 1, 6, 5, 2, 4, 3 };

    private void Start()
    {
        // �W�v
        int sum = intList.Sum();
        Debug.Log(sum);

        // ����
        var average = intList.Average();
        Debug.Log(average);

        // �J�E���g
        // 3�ȉ��̐����J�E���g
        var count = intList.Count(i => i <= 3);
        Debug.Log(count);

        // �ő�
        var max = intList.Max();
        Debug.Log(max);

        // �ŏ�
        var min = intList.Min();
        Debug.Log(min);
    }
}
