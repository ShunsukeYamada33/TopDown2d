using System.Security.Principal;
using System;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class StudyDelegation : MonoBehaviour
{
    // 委譲(任せる) Delegation
    // 機能の一部を他のクラスに任せる

    // キャラクターのインターフェースを継承した 戦士 魔法使い を考える
    // ダメージを受ける処理は共通なので他のクラスに任せる


    // キャラクターを用いた例
    public interface ICharacter
    {
        string Name { get; set; }
        int Health { get; set; }
        int PhysicAttack { get; set; }
        int MagicAttack { get; set; }

        void Attack(ICharacter target);
        void TakeDamage(int damage);
    }

    // 委譲用のクラス(ダメージを受ける処理を任せる)
    private class TakeDamageDelegation
    {
        // 任せてくるインターフェースを持つ。
        private readonly ICharacter _character;

        // コンストラクタで設定
        public TakeDamageDelegation(ICharacter character)
        {
            _character = character;
        }

        public void TakeDamage(int damage)
        {
            _character.Health -= damage;
        }
    }


    private class Warrior : ICharacter
    {
        // インタフェースが持つプロパティやメソッドは必ず実装する必要がある。
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        private readonly TakeDamageDelegation _takeDamage;

        public Warrior()
        {
            _takeDamage = new TakeDamageDelegation(this);
        }

        public void Attack(ICharacter target)
        {
            // 戦士は物理攻撃力をダメージとする
            target.TakeDamage(PhysicAttack);
        }

        public void TakeDamage(int damage)
        {
            _takeDamage.TakeDamage(damage);
        }
    }

    private class Wizard : ICharacter
    {
        // インタフェースが持つプロパティやメソッドは必ず実装する必要がある。
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        private TakeDamageDelegation _takeDamage;

        public Wizard()
        {
            _takeDamage = new TakeDamageDelegation(this);
        }

        public void Attack(ICharacter target)
        {
            // 魔法使いは魔法攻撃力をダメージとする
            target.TakeDamage(MagicAttack);
        }

        public void TakeDamage(int damage)
        {
            _takeDamage.TakeDamage(damage);
        }
    }

    // 新しいクラスが作成されてる
    // そもそも 戦士 魔法使い クラスの記述が増える
    // ややこしい

    // TakeDamageDelegationクラスのTakeDamageメソッドが変更されたときに
    // 変更する場所は1か所で済む

    // 共通の処理を何度も記述しなくて済む
    // 共通の処理が変更されたときに修正箇所が１か所で済む


    // インターフェースの継承と委譲を上手に使いこなすと
    // 
}
