using UnityEngine;

public class StudyPolymorphism : MonoBehaviour
{
    // ポリモーフィズム polymorphism 多様性
    // オブジェクト指向３要素

    // キャラクターがいます。
    // 戦士のキャラクター、魔法使いのキャラクター、盗賊のキャラクター 多様性がある
    // 少しずつできることが違うとする。

    // キャラクターを用いた例
    private class Character
    {
        public string name;
        public int health;
        public int physicAttack;
        public int magicAttack;
        public void Attack(Character target)
        {
            target.TakeDamage(physicAttack);
        }
        public void TakeDamage(int damage) { }
    }

    private class Warrior : Character
    {
    }

    private class Wizard : Character
    {
        // public void Attack(Character target)
        // {
        //     魔法使いは magicAttack で攻撃
        //     target.TakeDamage(magicAttack);
        // }
    }

    // この例を少し変えるだけで WizardクラスのAttackメソッドを実装する方法あります。
    // オーバーライド override

    // この講座では非推奨ということで知りたい方は調べてください。
}
