using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinqDataManipulation : MonoBehaviour
{
    // LINQ データの操作
    // take      最初のn個の要素に絞る
    // skip      最初のn個の要素はスキップ
    // distinct  重複をなくす

    List<int> intList = new() { 1, 6, 4, 1, 4, 3 };

    private void Start()
    {
        // 最初のn個の要素に絞る
        var take = intList.OrderBy(i => i).Take(3);
        foreach (int i in take)
        {
            Debug.Log(i);
        }

        // 1, 1, 3

        // 最初のn個の要素はスキップ
        var skip = intList.OrderBy(i => i).Skip(3);
        foreach (int i in skip)
        {
            Debug.Log(i);
        }

        // 4, 4, 6

        // 最初のn個の要素はスキップ
        var distinct = intList.Distinct();
        foreach (int i in distinct)
        {
            Debug.Log(i);
        }

        // 1, 6, 4, 3
    }
}
