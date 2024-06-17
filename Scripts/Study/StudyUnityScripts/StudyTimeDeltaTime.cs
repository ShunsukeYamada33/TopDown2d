using UnityEngine;

public class StudyTimeDeltaTime : MonoBehaviour
{
    // Time.deltaTime
    // 前回の Update された時間から経過した時間(秒)を取得できる。

    private float timer;
    private float speed = 1;

    private void Update()
    {
        // Time.deltaTime
        // 前回の Update された時間から経過した時間(秒)を取得できる。
        Debug.Log(Time.deltaTime);

        timer += Time.deltaTime;
        // ゲームオブジェクトが動いている時間の合計
        Debug.Log(timer);


        // オブジェクトの移動にも使える。
        var position = transform.position;
        position.x += speed * Time.deltaTime;
        transform.position = position;

        // 距離 = 速さ speed * 時間 Time.deltaTime
    }

    private void FixedUpdate()
    {
        var position = transform.position;
        position.x += speed;
        transform.position = position;

        // FixedUpdateでは時間は一定
    }

    // Updateで移動の処理をした方が滑らかになる
    // 処理としては 頻度が多い + 計算が複雑 なため重い
}
