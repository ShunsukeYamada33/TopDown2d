using UnityEngine;

public class StudyActive : MonoBehaviour
{
    // SetActive
    // activeSelf

    private void Start()
    {
        // �Q�[���I�u�W�F�N�g�̃A�N�e�B�u��؂�ւ���
        gameObject.SetActive(false);
        gameObject.SetActive(true);

        // �A�N�e�B�u���ǂ����擾�ł���B
        Debug.Log(gameObject.activeSelf);
    }
}
