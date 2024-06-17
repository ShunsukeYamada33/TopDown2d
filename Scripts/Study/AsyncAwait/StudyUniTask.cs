using Cysharp.Threading.Tasks;
using UnityEngine;

public class StudyUniTask : MonoBehaviour
{
    // UniTask
    // UniTask     基本の非同期メソッドの戻り値の型
    // UniTask<>   非同期処理が完了後に戻り値を受け取る
    // UniTaskVoid 非同期処理の完了を待てない戻り値の型(await できない)

    private void Start()
    {
        // Forget 非同期処理の完了を待たない
        Method01().Forget();

        // UniTaskVoidは await できない
        // await Method01();
    }

    private async UniTaskVoid Method01()
    {
        // 非同期処理の完了後に戻り値を受け取る
        var message = await Method02();
    }

    // UniTask<> 非同期処理の完了後に戻り値を返す。
    private async UniTask<string> Method02()
    {
        await UniTask.WaitForSeconds(1.0f);
        return "完了";
    }
}
