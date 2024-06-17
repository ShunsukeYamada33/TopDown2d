using UnityEngine;

public class StudyInheritance : MonoBehaviour
{
    // 継承 Inheritance
    // オブジェクト指向３要素

    // あるクラスのメンバを、他のクラスに引継ぐ（継承させる）機能
    // 継承元クラスの親クラス(Super class)


    // 継承のやり方
    // 継承元クラス(親クラス)
    private class Parent
    {
        public string name = "親";
        public void ParentMethod()
        {
            Debug.Log("親のメソッド");
        }
    }

    // アクセス修飾子 class 名前 : 継承元クラス
    private class Child : Parent
    {
        private void ChildMethod()
        {
            // 親のフィールドを使える
            Debug.Log(name);

            // 親のメソッドを使える
            ParentMethod();
        }
    }

    // 継承とは継承元のクラスの機能を継承先のクラスで使用できるようにすること
    // Battler 戦闘できるクラス
    // Player : Battler
    // Enemy : Battler
    // Warrior : Player
    // Wizard : Player
    // Thief : Player

    // ある時、Thief 逃げる機能が欲しいとなる
    // Thief に逃げるを実装
    // 後日、逃げる機能の仕様変更
    // Player が持っている逃げる機能を変更
    // Thief の逃げる機能だけ独自仕様のままとなりバグが発生

    // 注意点
    // 何度も継承できる。
    // 子供が結局どのクラスを継承しているのかわからなくなる。
    // 似たようなメソッドが複数乱立している。
    // バグの温床、スパゲッティコードの原因
}
