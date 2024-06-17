using Unity.VisualScripting;
using UnityEngine;

public class StudySingleton : MonoBehaviour
{
    // シングルトン Singleton
    // インスタンスが1つしか存在しないことを保証する


    // シングルトンインスタンス
    // 外部から参照できるようにするために public static で宣言
    // プロパティで外部からの変更を禁止
    public static StudySingleton Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // シーンを切り替えてもオブジェクトが破棄されないようにする
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 既にインスタンスが存在する場合は削除
            Destroy(gameObject);
        }
    }

    public float timer { get; private set; }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    // ゲームが開始してからの経過時間をいつでも取得できるようになる。
}
