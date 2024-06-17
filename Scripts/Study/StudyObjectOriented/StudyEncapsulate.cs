using UnityEngine;

public class StudyEncapsulate : MonoBehaviour
{
    // カプセル化
    // オブジェクト指向３要素

    // 他のオブジェクトに必要な機能だけを公開すること
    // 不要な機能は公開しないこと
    // 他のオブジェクトから不要な処理をされることで発生するバグを防ぐ

    // キャラクター
    public class Character
    {
        string characterName;
        int health;
        int attack;

        void Attack(Character character)
        {
            // 攻撃の処理
            character.TakeDamage(attack);
        }

        void TakeDamage(int damage)
        {
            health -= damage;
            Debug.Log(characterName + "の攻撃" + damage + "のダメージ。");
        }
    }

    // characterName を他のオブジェクトに書き換えられたら別人……
    // health を他のオブジェクトに書き換えられていつのまにか死亡している……
    // attack を他のオブジェクトに書き換えれたらいつのまにか最強、最弱に……
    // TakeDamage() を何度も実行されていつのまにか死亡している……
    
    // 他のキャラクターに攻撃する処理は公開してもよい
}
