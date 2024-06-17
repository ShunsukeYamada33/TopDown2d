using UnityEngine;

public class StudyStatic : MonoBehaviour
{
    // Static 静的
    // 静的クラス 静的フィールド 静的メソッドの宣言で使う。

    // アクセス修飾子 static 型 名前 の順
    // static は頭文字を大文字にした方がよい。
    public static int Int;
    public static void Method01()
    {

    }

    // static class
    private static class Character
    {
        // static class は全てのフィールドやメソッドを static にする必要がある。
        public static int Status01 = 0;
        //public int status02;

        public static void Method01()
        {

        }

        // public void Method02() { }
    }

    private void Start()
    {
        // 使用する際は変数名ではなく class名から直接入力
        Debug.Log(Character.Status01);
        Character.Method01();

        // static class は初期化できない。
        // Character character = new Character();
    }

    // 注意点
    // static なメソッドでは static ではないフィールドを利用できない。
    public int int01;

    public static void Method02()
    {
        //Debug.Log(int01);
        int int02 = 0;
        Debug.Log(int02);
    }

    // どのクラスからでもアクセスできてしまう
    // 必要な機能だけを公開するというカプセル化の考え方の逆
    // オブジェクト指向的ではないので使うところは気を付ける必要あり。
}
