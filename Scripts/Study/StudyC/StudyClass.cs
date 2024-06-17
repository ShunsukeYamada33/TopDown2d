using UnityEngine;

public class StudyClass : MonoBehaviour
{
    // クラス
    // メソッドとフィールドをまとめて特定の機能を実装した
    // 型


    // 例えばこのクラスがプレイヤーを表すクラス
    string playerName;
    int health;
    int attack;

    // class も型なので引数や戻り値の型として使用できる。
    void Attack(StudyClass target)
    {
        // target に攻撃する処理
        target.TakeDamage(attack);
    }

    void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log(playerName + "は" + damage + "のダメージを受けた");
    }

    void Start()
    {
        // class は型なので初期化して変数として利用できる。
        StudyClass character = new StudyClass();
        StudyClass target = new();

        // character は target に攻撃する処理
        character.Attack(target);
    }
}
