using UnityEngine;

public class StudyConstructor : MonoBehaviour
{
    // constructor コンストラクター
    // インスタンス化する際に実行される処理のこと
    // 基本的に private なフィールドや readonly なフィールドの初期化に利用される

    private class Character
    {
        // private なフィールドの初期化
        // readonly なメソッドの初期化もできる
        private readonly string _name;

        // セットでプロパティも用意するとよい
        public string Name { get => _name; }

        // コンストラクタ
        // class名と同じ名前のメソッドような記述 (戻り値の型はない)
        public Character()
        {
            _name = "無職";
        }

        // 引数を追加できる。
        // 引数を変えてコンストラクタは複数作れる
        public Character(string name)
        {
            _name = name;
        }
    }

    private void Start()
    {
        // コンストラクタを利用したインスタンス化
        Character none = new Character();
        Character warrior = new Character("戦士");
        Character wizard = new Character("魔法使い");

        Debug.Log(none.Name);
        Debug.Log(warrior.Name);
        Debug.Log(wizard.Name);

        // コンストラクタを利用することで
        // 初期化以降で値の変更ができなくできる
        // 値を設定できるタイミングを縛るというカプセル化
    }
}
