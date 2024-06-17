using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    // Transform
    // 位置、回転、サイズ情報をそれぞれVector3で持っている。

    [SerializeField] private Transform _transform;

    void Start()
    {
        // 自身のTransformの取得
        // 何度も取得するのは若干重いので何度も使用する場合はローカル変数にいれたほうがよい
        _transform = transform;

        // 位置の変更
        Vector3 position = _transform.position;
        position.x = 2;
        position.y = 2;
        _transform.position = position;

        // 回転の変更
        Vector3 rotation = _transform.eulerAngles;
        rotation.x = 100;
        rotation.y = 100;
        _transform.eulerAngles = rotation;

        // サイズの変更
        Vector3 size = _transform.localScale;
        size.x = 2;
        size.y = 2;
        _transform.localScale = size;
    }
}
