using UnityEngine;
using UnityEngine.Pool;

public class StudyObjectPool : MonoBehaviour
{
    // ゲームオブジェクトを大量に生成・破棄（Instantiate・Destroy)は負荷が高い
    // 必要に応じてアクティブを切り替えことで負荷を軽減しよう

    private GameObject prefab;
    private ObjectPool<GameObject> objectPool;

    private void Start()
    {
        objectPool = new ObjectPool<GameObject>(
            CreateObject,     // 生成
            GetObject,        // 再利用
            ReleaseObject,    // 返却
            DestroyObject,    // 破棄
            true,             // オブジェクトプールに同一のインスタンスが登録されるとエラーを表示
            10);              // 最大サイズ

        // 足りないときはCreateObject, 足りてるときはGetObject
        var poolObject = objectPool.Get();

        // ReleaseObjectを実行
        objectPool.Release(poolObject);

        // オブジェクトプールの破棄
        objectPool.Clear();
    }

    // オブジェクトが足りないときに生成するメソッド
    // 基本はInstantiateで生成
    private GameObject CreateObject()
    {
        return Instantiate(prefab);
    }

    // オブジェクトが足りているときのメソッド
    // 基本はSetActive(true)
    private void GetObject(GameObject poolObject)
    {
        poolObject.SetActive(true);
    }

    // オブジェクトが返ってくるときのメソッド
    // 基本はSetActive(false)
    private void ReleaseObject(GameObject poolObject)
    {
        poolObject.SetActive(false);
    }

    // オブジェクトを破棄するときのメソッド
    // 基本はDestroy
    // 最大サイズを超えると自動で削除する。
    void DestroyObject(GameObject poolObject)
    {
        Destroy(poolObject);
    }
}
