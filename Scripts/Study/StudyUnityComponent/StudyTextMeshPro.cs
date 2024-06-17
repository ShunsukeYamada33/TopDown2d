using TMPro;
using UnityEngine;

public class StudyTextMeshPro : MonoBehaviour
{
    // TextMeshProUGUI
    // 基本のテキストを表すUI

    private TextMeshProUGUI _textMeshProUGUI;

    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        _textMeshProUGUI.text = "テキスト";
        _textMeshProUGUI.color = Color.white;

        // オーバーフロー
        // ページの時のみ
        // 今のページ
        _textMeshProUGUI.pageToDisplay = 2;
        // ページ数
        var count = _textMeshProUGUI.textInfo.pageCount;


        // リッチテキスト
        // https://docs.unity3d.com/ja/2023.2/Manual/StyledText.html
        // 特定の文字の色を変えたり、画像を文字の間に入れることも可能
    }

    private bool NextPage()
    {
        // 今のページ
        var currentPage = _textMeshProUGUI.pageToDisplay;
        // ページ数
        var pageCount = _textMeshProUGUI.textInfo.pageCount;

        if (currentPage < pageCount)
        {
            _textMeshProUGUI.pageToDisplay++;
            return true;
        }
        else
        {
            // 既に最後のページの場合
            return false;
        }
    }
}
