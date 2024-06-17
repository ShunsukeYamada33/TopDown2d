using UnityEngine;

public class StudyProperties : MonoBehaviour
{
    // プロパティ
    // フィールドの公開方法の詳細を設定できる

    // フィールドの扱いとして "値を設定する" と "値を取得する" がある。
    // "値を設定する" だけ公開など詳細を設定できる。

    private class Character01
    {
        public string name;
    }

    private void UseCharacter01()
    {
        Character01 character = new Character01();
        // 値を設定する
        character.name = "名前";
        // 値を取得する
        string name = character.name;
        Debug.Log(name);
    }


    // 例 "値を取得する" だけ可能にする。
    // プロパティの頭文字は大文字にするほうがよい。
    private class Character02
    {
        public string Name { get; private set; } = "初期化";
    }

    private void UseCharacter02()
    {
        Character02 character = new Character02();
        // 値を設定する
        // character.Name = "名前";
        // 値を取得する
        string name = character.Name;
        Debug.Log(name);
    }

    private class Character03
    {
        // ローカル変数をプロパティとして公開もできる
        private string privateName = "プライベート";

        public string Name
        {
            get => privateName;
            set => privateName = value;
        }

        // このような形で条件や計算をした上で値を更新、取得することもできる。
        public int Score
        {
            get
            {
                if (Score <= 0)
                {
                    return 0;
                }
                else
                {
                    return Score;
                }
            }

            set
            {
                if (Score < 1000)
                {
                    Score = value;
                }
                else
                {
                    Score = 1000;
                }
            }
        }
    }
}
