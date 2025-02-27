using UnityEngine;

public class StudySwitch : MonoBehaviour
{
    // Switch
    // 条件分岐

    void Start()
    {
        int int01 = 0;

        // switch ( 変数 )
        // {
        //   case 値:
        //      処理
        //      break;
        //   default:
        //      処理
        //      break;
        // }

        // 変数と case 後の値が等しい場合にその処理を実行
        switch (int01)
        {
            case 0:
                //処理�@
                break;
            case 1:
                //処理�A
                break;
            case 2:
                //処理�B
                break;
            default:
                //処理�C
                break;
        }


        // if文を利用して同様に記述できる。
        if (int01 == 0)
        {
            // 処理�@
        }
        else if (int01 == 1)
        {
            // 処理�A
        }
        else if (int01 == 2)
        {
            // 処理�B
        }
        else
        {
            // 処理�C
        }

        // default は if文の else ようなものでどの case にも等しくない場合に処理を実行する。



        // breakを付けない場合は処理を終了せずに次の case も確認する
        switch (int01)
        {
            case 0:
                //処理�@
            case 1:
                //処理�A
                break;
            case 2:
                //処理�B
                break;
        }

        // int01 が 0 の場合は 処理�@と処理�Aを実行
        // int01 が 1 の場合は 処理�Aを実行
        // int01 が 2 の場合は 処理�Bを実行

        // 意図的ではない場合に break を忘れてもエラーにならないので注意
    }
}
