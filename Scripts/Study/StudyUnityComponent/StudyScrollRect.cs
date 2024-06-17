using UnityEngine;
using UnityEngine.UI;

public class StudyScrollRect : MonoBehaviour
{
    // ScrollRect
    // スクロールできるUI

    private ScrollRect _scroll;

    private void Awake()
    {
        _scroll = GetComponent<ScrollRect>();
    }

    private void Start()
    {
        _scroll.onValueChanged.AddListener(OnValueChanged);

        // 水平方向のスクロール位置を 0 から 1 の間で表したもの。0 は左端
        _scroll.horizontalNormalizedPosition = 0;
        // 垂直方向のスクロール位置を 0 から 1 の間で表したもの。0 は下端
        _scroll.verticalNormalizedPosition = 1;
    }

    public void OnValueChanged(Vector2 vector2)
    {
        Debug.Log($"X:{vector2.x} Y:{vector2.y}");
    }
}
