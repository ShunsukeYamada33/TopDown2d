using UnityEngine;

public class StudyMethod : MonoBehaviour
{
    // メソッド　関数
    // メソッドの作成と利用


    // 基礎
    // void メソッド名()
    // {
    //   処理
    // }

    void Hello()
    {
        Debug.Log("こんにちは");
    }

    void Log0to9()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(i);
        }
    }

    // 戻り値
    // 戻り値の型 メソッド名()
    // {
    //   処理
    // }
    int Get10()
    {
        // 最後に return で戻り値の型と同じ値を返す。
        return 10;
    }

    // 引数
    // 戻り値の型 メソッド名(引数１の型 引数１, 引数２の型 引数２, ....... , 引数Nの型 引数N)
    // {
    //   処理
    // }
    int GetSum(int x, int y)
    {
        // 引数の値を処理内で利用できる。
        return x + y;
    }


    // Start()もメソッド
    void Start()
    {
        // メソッドの使用方法
        Hello();

        Log0to9();

        int x = Get10();
        int y = 5;
        int sun = GetSum(x, y);
    }
}
