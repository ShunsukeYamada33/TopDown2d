using UnityEngine;

public class StudyLifeCycleUpdate : MonoBehaviour
{
    // ライフサイクルイベント Update FixUpdate

    // Unity のゲームオブジェクトが生存中に実行される処理

    private void Update()
    {
        // 毎フレーム呼ばれる。

        // フレームとは
        // 処理が軽ければたくさん呼ばれる。
        // 処理が重ければ呼ばれる数が減る。
        // 実行タイミングが変化する。

        // 基本的にはたくさん呼ばれる。
        // ユーザーからの入力に対し使われることが多い。
    }

    private void FixedUpdate()
    {
        // 物理的な時間
        // 一定時間ごとに実行される。タイミングが不変

        // 物理的な計算に使われることが多い

        var position = transform.position;
        position.x += speed;
        transform.position = position;

        // 設定方法
        // Editor/Project Settings/Time/Fixed Timestamp
    }

    private float speed = 1;
}
