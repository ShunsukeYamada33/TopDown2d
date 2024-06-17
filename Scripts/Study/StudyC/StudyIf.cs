using UnityEngine;

public class StudyIf : MonoBehaviour
{
    // If
    // 条件分岐

    void Start()
    {
        int int01 = 10;

        // if ( 条件 true, false )
        // {
        //   処理
        // }

        // もしも()が true なら処理を実行
        if (int01 > 0)
        {
            // 処理
        }

        // else
        // もしも()が true なら処理�@を実行
        if (int01 > 1)
        {
            // 処理�@
        }
        // ここまで処理が行われていなければ処理�Aを実行
        else
        {
            // 処理�A
        }

        // else if
        // もしも()が true なら処理�@を実行
        if(int01 > 2)
        {
            // 処理�@
        }
        // もしも()が true なら処理�Aを実行
        else if (int01 > 3)
        {
            // 処理�A
        }
        // もしも()が true なら処理�Bを実行
        else if (int01 > 3)
        {
            // 処理�B
        }
        // ここまで処理が行われていなければ処理�Cを実行
        else
        {
            // 処理�C
        }


        // 上から確認していき、最初に true になった処理を実行
        // どれか最大一つだけ処理をして終了


        // 応用
        // 複数組み合わせられることもあるが考え方は同じ
        if (int01 > 5)
        {
            if (int01 > 6)
            {
                // 処理�@
            }
            else if (int01 > 7)
            {
                // 処理�A
            }

            if (int01 > 4)
            {
                // 処理�B
            }
            else
            {
                // 処理�C
            }
        }
        else if (int01 < 20)
        {
            // 処理�D
        }
    }
}
