using R3;
using UnityEngine;

public class StudyFiltering : MonoBehaviour
{
    // フィルタリング
    // 通知を受け取る際の条件を指定できる
    private Subject<int> subject = new();

    private void Start()
    {
        // Where
        // 条件を満たした時のみ処理
        subject.Where(x => x < 10).Subscribe();

        // DistinctUntilChanged
        // 前回の値と同じ場合は遮断し、異なる場合のみ処理
        subject.DistinctUntilChanged().Subscribe();

        // Skip
        // 最初のn回分無視する
        // ReactivePropertyの初回実行したくない場合によく実行
        subject.Skip(1).Subscribe();

        // Take
        // 最初のn回だけ処理
        subject.Take(1).Subscribe();

        // Select
        // 受け取った値を変換して処理
        subject.Select(x => x * 2).Subscribe();
    }
}
