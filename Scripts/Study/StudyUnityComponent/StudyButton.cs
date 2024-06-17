using UnityEngine;
using UnityEngine.UI;

public class StudyButton : MonoBehaviour
{
    // Button
    // �{�^��UI

    private Button _button;

    private void Awake()
    {
        _button = GetComponent<Button>();
    }

    void Start()
    {
        // �X�N���v�g���珈����ǉ�������@
        _button.onClick.AddListener(OnClickAddListener);
        _button.onClick.AddListener(() => OnClickAddListener("��������"));
    }

    private void OnClickAddListener()
    {
        Debug.Log("onClick.AddListener �𗘗p�����N���b�N�����̒ǉ�");
    }

    private void OnClickAddListener(string text)
    {
        Debug.Log(text);
    }

    // public�ɂ���K�v������B
    public void OnClick()
    {
        Debug.Log("OnClick �𗘗p�����N���b�N�����̒ǉ�");
    }

    public void OnClick(string text)
    {
        Debug.Log(text);
    }

    // �g��Ȃ��Ń{�^���̋@�\��^����̂��ȒP�B
    // �{�^�����g��Ȃ����Ƃ𐄏�����l�����܂��B
}
