using UnityEngine;

public class StudyInstance : MonoBehaviour
{
    // instance インスタンス
    // クラスは設計図
    // インスタンスはクラスから作られた "実物"

    void Start()
    {
        // Character は設計図
        // warrior, wizard インスタンス
        // 設計図から作られた実際のキャラクター
        // 今まで使用していた new というのは実物を作ること インスタンス化
        Character warrior = new Character();
        Character wizard = new Character();
    }

    class Character
    {

    }
}
