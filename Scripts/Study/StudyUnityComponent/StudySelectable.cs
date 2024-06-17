using UnityEngine;
using UnityEngine.UI;

public class StudySelectable : MonoBehaviour
{
    // Selectable
    // �L�[�{�[�h��R���g���[���[�ŊȒP�ɑI����Ԃ̑J�ڂ�������

    private Selectable _selectable;

    private void Awake()
    {
        _selectable = GetComponent<Selectable>();
    }

    void Start()
    {
        // �I����Ԃɂ���
        _selectable.Select();
        // �I���̉�
        _selectable.enabled = true;
        // ��Ԃ��ς��A�������ƐF���O���[�A�I��s��
        _selectable.interactable = true;
    }
}
