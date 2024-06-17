using UnityEngine;

public class StudySpriteRenderer : MonoBehaviour
{
    // SpriteRenderer
    // �Q�[���I�u�W�F�N�g�̉摜������

    private SpriteRenderer _spriteRenderer;

    // �摜���̂���
    public Sprite sprite;
    // �F
    public Color color;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        // �l�̕ύX
        _spriteRenderer.sprite = sprite;
        _spriteRenderer.color = color;
        _spriteRenderer.flipX = true;
        _spriteRenderer.flipY = true;
    }
}
