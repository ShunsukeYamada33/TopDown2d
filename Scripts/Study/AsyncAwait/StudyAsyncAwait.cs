using Cysharp.Threading.Tasks;
using DG.Tweening;
using R3;
using UnityEngine;

public class StudyAsyncAwait : MonoBehaviour
{
    // 非同期処理
    // 特定の処理が終了するまで待つ。

    // async   非同期のメソッドであると宣言
    // await   メソッド内で待つ
    // UniTask Unityでの非同期処理の戻り値の型

    private Subject<Unit> subject = new Subject<Unit>();

    private void Start()
    {
        // Forget 非同期処理の完了を待たない
        Method01().Forget();
    }


    // 非同期処理をするメソッドですという宣言 async
    // アクセス修飾子 async 戻り値型 メソッド名(引数1型 引数1, ......)
    private async UniTask Method01()
    {
        // 1秒待つ
        await UniTask.WaitForSeconds(1.0f);

        // 他の非同期処理を待つ。戻り値の型は UniTask
        await Method02();

        // Forget 非同期処理の完了を待たない
        Method02().Forget();

        // DoTweenのアニメーションの完了を待つ AsyncWaitForCompletion
        await transform.DOMove(new Vector3(1.0f, 1.0f, 0.0f), 1.0f).AsyncWaitForCompletion();

        // R3のSubjectに対し最初に OnNext() されるまで待つ
        await subject.FirstAsync();

        // キャンセル処理を今回は取り扱わないが大切
    }

    private async UniTask Method02()
    {
        await UniTask.WaitForSeconds(1.0f);
    }
}
