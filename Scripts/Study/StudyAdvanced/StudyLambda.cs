using UnityEngine;

public class StudyLambda : MonoBehaviour
{
    // Lambda ラムダ

    // メソッドを一時的に作成する方法

    private delegate void MyDelegate01();
    private delegate void MyDelegate02(string text);
    private delegate void MyDelegate03(string text01, string text02);
    private delegate string MyDelegate04(string text01, string text02);

    private void Method()
    {
        // 基本的な記述
        // 左辺 => 右辺

        // (引数１, ....) => 処理;
        MyDelegate01 myDelegate01 = () => Debug.Log("ラムダ");
        MyDelegate02 myDelegate02 = (argument) => Debug.Log(argument);
        // MyDelegate02 myDelegate02 = argument => Debug.Log(argument);
        MyDelegate03 myDelegate03 = (argument01, argument02) => Debug.Log(argument01 + argument02);


        // (引数１, ....) =>
        // {
        //    処理
        // };

        MyDelegate01 myDelegate05 = () =>
        {
            Debug.Log("処理1");
            Debug.Log("処理2");
            Debug.Log("処理3");
        };

        // 戻り値ありの場合
        MyDelegate04 myDelegate04 = (argument01, argument02) => { return argument01 + argument02; };

        // こう覚えてもよいかも
        // () => {};
        // MyDelegate01 myDelegate01 = () => { Debug.Log("ラムダ"); };
        // MyDelegate02 myDelegate02 = (argument) => { Debug.Log(argument); };
        // MyDelegate03 myDelegate03 = (argument01, argument02) => { Debug.Log(argument01 + argument02); };
    }
}
