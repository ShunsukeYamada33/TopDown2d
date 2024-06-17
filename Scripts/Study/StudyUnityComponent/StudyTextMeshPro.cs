using TMPro;
using UnityEngine;

public class StudyTextMeshPro : MonoBehaviour
{
    // TextMeshProUGUI
    // ��{�̃e�L�X�g��\��UI

    private TextMeshProUGUI _textMeshProUGUI;

    private void Awake()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
        _textMeshProUGUI.text = "�e�L�X�g";
        _textMeshProUGUI.color = Color.white;

        // �I�[�o�[�t���[
        // �y�[�W�̎��̂�
        // ���̃y�[�W
        _textMeshProUGUI.pageToDisplay = 2;
        // �y�[�W��
        var count = _textMeshProUGUI.textInfo.pageCount;


        // ���b�`�e�L�X�g
        // https://docs.unity3d.com/ja/2023.2/Manual/StyledText.html
        // ����̕����̐F��ς�����A�摜�𕶎��̊Ԃɓ���邱�Ƃ��\
    }

    private bool NextPage()
    {
        // ���̃y�[�W
        var currentPage = _textMeshProUGUI.pageToDisplay;
        // �y�[�W��
        var pageCount = _textMeshProUGUI.textInfo.pageCount;

        if (currentPage < pageCount)
        {
            _textMeshProUGUI.pageToDisplay++;
            return true;
        }
        else
        {
            // ���ɍŌ�̃y�[�W�̏ꍇ
            return false;
        }
    }
}
