using ObservableCollections;
using R3;
using UnityEngine;

public class StudyObservableList : MonoBehaviour
{
    // ObservableList

    // リアクティブプログラミングとは
    // リストの要素、要素数が変わると自動で通知する。
    public ObservableList<int> observableList = new();

    public void Method01()
    {
        // 要素が追加された場合に実行
        observableList.ObserveAdd().Subscribe(x => Debug.Log(x.Value));
        observableList.ObserveAdd().Subscribe(AddEvent);

        // 要素が削除された場合に実行
        observableList.ObserveRemove().Subscribe(RemoveEvent);

        // 要素数が変更された場合に実行
        observableList.ObserveCountChanged().Subscribe(CountChanged);

        // 要素の値が上書きされた場合に実行
        observableList.ObserveReplace().Subscribe(Replace);

        // リセット
        observableList.ObserveReset().Subscribe(ObserveReset);
    }

    // CollectionAddEvent
    private void AddEvent(CollectionAddEvent<int> x)
    {
        Debug.Log(x.Value);
    }

    private void RemoveEvent(CollectionRemoveEvent<int> x)
    {
        Debug.Log(x.Value);
    }

    private void CountChanged(int  count)
    {
        Debug.Log(count);
    }

    private void Replace(CollectionReplaceEvent<int> x)
    {
        Debug.Log(x);
    }

    private void ObserveReset(Unit _)
    {
        Debug.Log("リセット");
    }
}
