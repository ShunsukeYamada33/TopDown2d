using UnityEngine;

public class StudySpriteRenderer : MonoBehaviour
{
    // SpriteRenderer
    // ゲームオブジェクトの画像を扱う

    private SpriteRenderer _spriteRenderer;

    // 画像そのもの
    public Sprite sprite;
    // 色
    public Color color;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        // 値の変更
        _spriteRenderer.sprite = sprite;
        _spriteRenderer.color = color;
        _spriteRenderer.flipX = true;
        _spriteRenderer.flipY = true;
    }
}
