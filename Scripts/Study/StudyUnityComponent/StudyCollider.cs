using UnityEngine;

public class StudyCollider : MonoBehaviour
{
    // Collider2D
    // 当たり判定を行う

    private BoxCollider2D _boxCollider;
    private CircleCollider2D _circleCollider;

    private void Awake()
    {
        _circleCollider = GetComponent<CircleCollider2D>();
    }

    void Start()
    {
        _circleCollider.isTrigger = false;

        _circleCollider.radius = 1.0f;
        // BoxCollider2D の場合は size など　コライダーによって異なる
        // boxCollider.size = new Vector2(10, 10);
    }
}
