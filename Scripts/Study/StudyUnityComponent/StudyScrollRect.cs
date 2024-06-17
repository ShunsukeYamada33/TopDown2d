using UnityEngine;
using UnityEngine.UI;

public class StudyScrollRect : MonoBehaviour
{
    // ScrollRect
    // �X�N���[���ł���UI

    private ScrollRect _scroll;

    private void Awake()
    {
        _scroll = GetComponent<ScrollRect>();
    }

    private void Start()
    {
        _scroll.onValueChanged.AddListener(OnValueChanged);

        // ���������̃X�N���[���ʒu�� 0 ���� 1 �̊Ԃŕ\�������́B0 �͍��[
        _scroll.horizontalNormalizedPosition = 0;
        // ���������̃X�N���[���ʒu�� 0 ���� 1 �̊Ԃŕ\�������́B0 �͉��[
        _scroll.verticalNormalizedPosition = 1;
    }

    public void OnValueChanged(Vector2 vector2)
    {
        Debug.Log($"X:{vector2.x} Y:{vector2.y}");
    }
}
