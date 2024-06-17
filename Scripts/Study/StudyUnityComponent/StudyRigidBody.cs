using UnityEngine;

public class StudyRigidBody : MonoBehaviour
{
    // Rigidbody2D
    // �������Z���s��

    private Rigidbody2D _rigidBody2D;

    private void Awake()
    {
        _rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        // ���x��ύX
        _rigidBody2D.velocity = Vector2.zero;
        Debug.Log(_rigidBody2D.velocity);

        // X, Y �̑��x��ύX���ł���
        //test02.velocityX
        //test02.velocityY

        _rigidBody2D.mass = 1.0f;
        _rigidBody2D.gravityScale = 0.0f;

        // �����I�ȗ͂�������
        _rigidBody2D.AddForce(new Vector2(1.0f, 0.0f));
    }
}
