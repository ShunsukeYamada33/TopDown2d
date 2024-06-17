using UnityEngine;

public class StudyFor : MonoBehaviour
{
    // For
    // 繰り返し処理

    void Start()
    {
        // for ( 初期値 ; 条件 ; 増減処理)
        // {
        //    処理
        // }

        int sum01 = 0;
        for(int i = 0; i < 10; i++)
        {
            //処理
            sum01 += i;
        }
        // i の合計を求める


        // 処理の流れ
        // ①初期化 int i = 0
        // ②条件の確認 i < 10
        // ③処理
        // ④増減処理 i++
        // ⑤条件の確認
        // 省略
        // 条件が false になっていたら終了

        // 初期値、条件、増減処理を１行に記載できるので while よりも無限ループになりにくい
        // 無限ループに注意


        // 例
        int sum02 = 0;
        for(int i = 10; i > 0; i--)
        {
            // 処理
            sum02 += i;
        }

        int sum03 = 0;
        for (int i = 0; i < 10; i += 3)
        {
            // 処理
            sum03 += i;
        }
    }
}
