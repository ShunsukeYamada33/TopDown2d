using UnityEngine;

public class StudyAccessModifier : MonoBehaviour
{
    // アクセス修飾子
    // どのフィールドやメソッドを他の物に公開するか宣言するもの

    public class Character
    {
        // プライベート
        // 他のオブジェクトに公開しない。
        // 自身の class 内のみで操作できる。
        // 省略可能
        // 頭文字に "_" を付けるのがよい
        int _privateInt01 = 0;
        private int _privateInt02 = 0;

        // パブリック
        // 他のオブジェクトに公開
        // 他の class で操作ができる
        public int publicInt = 0;

        // Unity専用
        // 他のオブジェクトに公開しない。
        // 自身の class 内のみで操作できる。
        // ただし Unity Editor で操作できる。
        [SerializeField] private int serializeFieldInt = 0;

        private void privateMethod()
        {
            // 自身の class 内だと全て使用可能
            Debug.Log(_privateInt01);
            Debug.Log(_privateInt02);
            Debug.Log(publicInt);
            Debug.Log(serializeFieldInt);
        }

        public void publicMethod()
        {
            privateMethod();
        }
    }

    private void Start()
    {
        Character character = new Character();

        // public のアクセス修飾子を付けたもののみアクセスできる。
        //character.privateInt01 = 0;
        //character.privateInt02 = 0;
        character.publicInt = 0;
        //character.serializeFieldInt = 0;

        // メソッドも同様に public のみアクセス可能
        //character.privateMethod();
        character.publicMethod();
    }
}
