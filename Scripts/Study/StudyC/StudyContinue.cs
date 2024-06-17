using System.Collections.Generic;
using UnityEngine;

public class StudyContinue : MonoBehaviour
{
    // Continue
    // 繰り返し処理の継続

    void Start()
    {
        // while での使用
        int int02 = 0;
        int int03 = 0;
        while (int02 < 3)
        {
            // 処理
            int03++;

            if (int03 < 3)
            {
                continue;
            }

            // 処理
            int02++;
        }

        // for での使用
        int int04 = 0;
        for (int int05 = 0; int05 < 6; int05++)
        {
            // 処理

            if (int04 > 3)
            {
                continue;
            }

            // 処理

            int04++;
        }

        // foreach での使用
        List<int> intList = new() { 3, 4, 5, 6, 7, 8, 9, };
        foreach (int i in intList)
        {
            // 処理

            if (i > 5)
            {
                continue;
            }

            // 処理
        }
    }
}
