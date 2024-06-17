using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinqSelect : MonoBehaviour
{
    // LINQ データの変換
    // Select

    List<int> intList = new() { 1, 6, 5, 2, 4, 3 };

    private void Start()
    {
        // 全ての要素を３倍する
        var listSelect = intList.Select(i => i * 3);
        foreach (var i in listSelect)
        {
            Debug.Log(i);
        }

        // 3, 18, 15, 6, 12, 9

        // 3以下にフィルタリング
        // 要素を3倍
        var list = intList.Where(i => i <= 3).Select(i => i * 3);
        foreach (var i in list)
        {
            Debug.Log(i);
        }

        // 3, 6, 9


        // 元のリストが変わったわけではない。
    }
}
