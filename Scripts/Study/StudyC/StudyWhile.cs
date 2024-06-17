using UnityEngine;

public class StudyWhile : MonoBehaviour
{
    // while
    // 繰り返し処理

    void Start()
    {
        int int01 = 0;

        // while ( 条件 true, false )
        // {
        //    処理
        // }
        // 条件を満たしている限り 処理を繰り返し実行


        while (int01 < 10)
        {
            //処理

            int01++;
        }
        // 処理を満たし続ける限り処理を実行するので 無限に処理を実行してしまう可能性がある。
        // 無限ループ に注意

        do
        {
            //処理
            int01++;
        } while (int01 < 10);
        // do while 文
        // whileとの違いは do while は最初の１回は必ず処理をする。
    }
}
