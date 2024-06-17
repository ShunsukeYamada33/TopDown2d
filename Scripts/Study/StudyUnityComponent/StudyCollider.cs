using UnityEngine;

public class StudyCollider : MonoBehaviour
{
    // Collider2D
    // �����蔻����s��

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
        // BoxCollider2D �̏ꍇ�� size �Ȃǁ@�R���C�_�[�ɂ���ĈقȂ�
        // boxCollider.size = new Vector2(10, 10);
    }
}
