using System.Collections.Generic;
using UnityEngine;

public class StudyContinue : MonoBehaviour
{
    // Continue
    // �J��Ԃ������̌p��

    void Start()
    {
        // while �ł̎g�p
        int int02 = 0;
        int int03 = 0;
        while (int02 < 3)
        {
            // ����
            int03++;

            if (int03 < 3)
            {
                continue;
            }

            // ����
            int02++;
        }

        // for �ł̎g�p
        int int04 = 0;
        for (int int05 = 0; int05 < 6; int05++)
        {
            // ����

            if (int04 > 3)
            {
                continue;
            }

            // ����

            int04++;
        }

        // foreach �ł̎g�p
        List<int> intList = new() { 3, 4, 5, 6, 7, 8, 9, };
        foreach (int i in intList)
        {
            // ����

            if (i > 5)
            {
                continue;
            }

            // ����
        }
    }
}
