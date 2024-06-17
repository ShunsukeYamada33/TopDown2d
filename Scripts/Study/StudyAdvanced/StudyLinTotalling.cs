using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinTotalling : MonoBehaviour
{
    // LINQ データの集計
    // sum     合計
    // average 平均
    // count   カウント
    // max     最大
    // min     最小

    List<int> intList = new() { 1, 6, 5, 2, 4, 3 };

    private void Start()
    {
        // 集計
        int sum = intList.Sum();
        Debug.Log(sum);

        // 平均
        var average = intList.Average();
        Debug.Log(average);

        // カウント
        // 3以下の数をカウント
        var count = intList.Count(i => i <= 3);
        Debug.Log(count);

        // 最大
        var max = intList.Max();
        Debug.Log(max);

        // 最小
        var min = intList.Min();
        Debug.Log(min);
    }
}
