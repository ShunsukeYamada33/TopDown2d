using UnityEngine;

public class StudyRigidBody : MonoBehaviour
{
    // Rigidbody2D
    // 物理演算を行う

    private Rigidbody2D _rigidBody2D;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // 速度を変更
        _rigidBody2D.velocity = Vector2.zero;
        Debug.Log(_rigidBody2D.velocity);

        // X, Y の速度を変更もできる
        //test02.velocityX
        //test02.velocityY

        _rigidBody2D.mass = 1.0f;
        _rigidBody2D.gravityScale = 0.0f;

        // 物理的な力を加える
        _rigidBody2D.AddForce(new Vector2(1.0f, 0.0f));
    }
}
