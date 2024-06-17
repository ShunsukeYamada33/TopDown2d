using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinqOrderby : MonoBehaviour
{
    // LINQ 並び替え
    // OrderBy              昇順 だんだん大きくなるように並べる
    // OrderByDescending    降順 だんだん小さくなるように並べる

    List<int> intList = new() { 1, 6, 5, 2, 4, 3 };

    private void Start()
    {
        // 昇順に並べ替える
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

        // 文字列も並べ替えられる。a-z


        // 元のリストが変わったわけではない。
    }
}
