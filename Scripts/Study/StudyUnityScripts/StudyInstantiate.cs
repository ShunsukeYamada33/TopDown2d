using UnityEngine;

public class StudyInstantiate : MonoBehaviour
{
    // Instantiate ゲームオブジェクトの生成

    [SerializeField] GameObject prefab;

    private void Start()
    {
        // オブジェクトの生成
        var newObject01 = Instantiate(prefab);

        // 親の指定
        var newObject02 = Instantiate(prefab, transform);

        // 位置、回転の指定
        var position = new Vector3(2, 2, 0);
        var rotation = transform.rotation;
        // Quaternion.identity 回転なし
        var newObject03 = Instantiate(prefab, position, Quaternion.identity, transform);
    }
}
