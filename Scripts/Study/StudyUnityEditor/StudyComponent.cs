using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    // Component コンポーネント
    // ゲームオブジェクトに付く機能のこと

    // Attack, Take, Move コンポーネントがある
    // Attack, Take, Move 基本のキャラクター
    // Take               壁
    // Attack, Move       無敵キャラクター
    // Attack, Take       固定砲台

    // コンポーネントの組み合わせで振る舞いが変えられる

    // MonoBehaviour を継承したもののみ付けられる

    private void Start()
    {
        // コンポーネントの追加
        var addComponent = gameObject.AddComponent<StudyComponent>();

        // コンポーネントの取得
        var getComponent = gameObject.GetComponent<StudyComponent>();
    }
}
