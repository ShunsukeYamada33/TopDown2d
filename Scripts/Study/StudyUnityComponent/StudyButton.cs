using UnityEngine;
using UnityEngine.UI;

public class StudyButton : MonoBehaviour
{
    // Button
    // ボタンUI

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    void Start()
    {
        // スクリプトから処理を追加する方法
        _button.onClick.AddListener(OnClickAddListener);
        _button.onClick.AddListener(() => OnClickAddListener("引数あり"));
    }

    private void OnClickAddListener()
    {
        Debug.Log("onClick.AddListener を利用したクリック処理の追加");
    }

    private void OnClickAddListener(string text)
    {
        Debug.Log(text);
    }

    // publicにする必要があり。
    public void OnClick()
    {
        Debug.Log("OnClick を利用したクリック処理の追加");
    }

    public void OnClick(string text)
    {
        Debug.Log(text);
    }

    // 使わないでボタンの機能を与えるのも簡単。
    // ボタンを使わないことを推奨する人もいます。
}
