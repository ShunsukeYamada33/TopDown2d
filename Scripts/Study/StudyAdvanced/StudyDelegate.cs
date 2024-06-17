using UnityEngine;

public class StudyDelegate : MonoBehaviour
{
    // デリゲート delegate 代表者

    // 処理を行い時に、直接メソッドを呼ぶのではなく、代表者を呼ぶ


    // アクセス修飾子 delegate 戻値の型 デリゲート名 ( 引数１の型, ......)
    private delegate void MyDelegate();

    private void MainMethod()
    {
        // 宣言
        // 省略系もある 一般には省略形が推奨されています。
        // MyDelegate myDelegate01 = new MyDelegate(Method01);
        MyDelegate myDelegate02 = Method01;

        // 呼び出し
        // デリゲートの呼び出しだとわかりやすいので Invoke で呼ぶのが一般的
        // myDelegate02();
        myDelegate02.Invoke();

        // 足すこともできる。
        myDelegate02 += Method02;
        // 引くこともできる。
        myDelegate02 -= Method01;

        // 戻り値や引数の型が一致していないとダメ
        // MyDelegate myDelegate03 = Method03;
        // MyDelegate myDelegate04 = Method04;
        IntDelegate01 intDelegate01 = Method03;
        IntDelegate02 intDelegate02 = Method04;
    }


    private void Method01()
    {
        Debug.Log("実行01");
    }

    private void Method02()
    {
        Debug.Log("実行02");
    }

    private int Method03()
    {
        return 0;
    }

    private void Method04(int i)
    {
        Debug.Log(i);
    }

    private delegate int IntDelegate01();
    private delegate void IntDelegate02(int i);
}
