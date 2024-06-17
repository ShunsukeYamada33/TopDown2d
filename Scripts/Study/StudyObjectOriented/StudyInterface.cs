using UnityEngine;

public class StudyInterface : MonoBehaviour
{
    // interface インタフェース

    // 日本語で 境界面、接続部分、共通境域

    // クラスはフィールド、プロパティ、メソッド等が実装可能
    // インタフェースはプロパティとメソッドの型と名前だけを宣言
    // できることを宣言して、やることは未実装


    // やり方
    // アクセス修飾子 interface 名前(頭文字にIを付けるのがよい)
    private interface ICharacter
    {
        // プロパティ
        string Name { get; }
        int Health { get; }
        int PhysicAttack { get; }
        int MagicAttack { get; }

        // メソッド
        // 実装がないので{}は省略して ; で終わる
        void Attack(ICharacter target);
        void TakeDamage(int damage);
    }


    private class Warrior : ICharacter
    {
        // インタフェースが持つプロパティやメソッドは必ず実装する必要がある。
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        public void Attack(ICharacter target)
        {
            // 戦士は物理攻撃力をダメージとする
            target.TakeDamage(PhysicAttack);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    private class Wizard : ICharacter
    {
        // インタフェースが持つプロパティやメソッドは必ず実装する必要がある。
        public string Name { get; set; }
        public int Health { get; set; }
        public int PhysicAttack { get; set; }
        public int MagicAttack { get; set; }

        public void Attack(ICharacter target)
        {
            // 魔法使いは魔法攻撃力をダメージとする
            target.TakeDamage(MagicAttack);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }

    // インタフェースを利用して強制的にクラスの機能を制限できる
    // 余計なメンバへのアクセスの制限をかけることができ、バグの発生を抑制できる。
    // 親や子供で作られたクラスへ間違った方法でアクセスされる危険が減少する。
    // 似たようなメソッドの乱立を防げる

    // インタフェースを利用した継承がおすすめ

    // 注意点
    // TakeDamageメソッドでは同じ処理を何度も記述する必要がある。
    // 仕様変更で全て漏れずに修正する必要がある。
}
