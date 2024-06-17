using UnityEngine;

public class StudyArgument : MonoBehaviour
{
    // 引数 argument
    // 引数 メソッドに対して入力する値のこと

    // 戻り値の型 メソッド名(引数１の型　引数１の変数名, 引数２の型　引数２の変数名, ..... 引数Nの型　引数Nの変数名) 
    void Sum(int int01, int int02)
    {
        int answer = int01 + int02;
        Debug.Log(answer);
    }

    void LogNameAndAge(string name, int age)
    {
        Debug.Log("名前:" + name + " 年齢: " + age + "歳");
    }


    void Start()
    {
        // 引数を設定したメソッドの実行
        // 実行時には型は不要。
        Sum(1, 2);
        LogNameAndAge("山田", 3);

        // 引数として与えた値の型が異なるとエラー
        // LogNameAndAge(1, 3);
    }
}
