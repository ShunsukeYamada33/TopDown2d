using UnityEngine;

public class StudyLifeCycleActive : MonoBehaviour
{
    // ���C�t�T�C�N���C�x���g �A�N�e�B�u�Ɋ֌W����

    // Unity �̃Q�[���I�u�W�F�N�g���������Ɏ��s����鏈��

    private void Awake()
    {
        // ���̃N���X(�Q�[���I�u�W�F�N�g���ŏ��Ƀ��[�h�i�ǂݍ��܂ꂽ�j���ꂽ�^�C�~���O
        // �P�x���s
        // ��ԍŏ�
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // �Q�[���I�u�W�F�N�g���A�N�e�B�u�ɂȂ����^�C�~���O
        // ���x�����s
        // 2�Ԗ�
        Debug.Log("OnEnable");
    }

    private void Start()
    {
        // �Q�[���I�u�W�F�N�g�������o�����O�̃^�C�~���O
        // �P�x���s
        // 3�Ԗ�
        Debug.Log("Start");
    }

    private void OnDisable()
    {
        // �Q�[���I�u�W�F�N�g����A�N�e�B�u�ɂȂ����^�C�~���O
        // ���x�����s
        Debug.Log("OnDisable");
    }
}
