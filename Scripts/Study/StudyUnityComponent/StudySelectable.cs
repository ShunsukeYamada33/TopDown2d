using UnityEngine;
using UnityEngine.UI;

public class StudySelectable : MonoBehaviour
{
    // Selectable
    // キーボードやコントローラーで簡単に選択状態の遷移をさせる

    private Selectable _selectable;

    private void Awake()
    {
        _selectable = GetComponent<Selectable>();
    }

    void Start()
    {
        // 選択状態にする
        _selectable.Select();
        // 選択の可否
        _selectable.enabled = true;
        // 状態が変わる、初期だと色がグレー、選択不可
        _selectable.interactable = true;
    }
}
