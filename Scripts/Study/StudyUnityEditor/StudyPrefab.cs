using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class StudyPrefab : MonoBehaviour
{
    // Prefab �v���t�@�u
    // �Q�[���I�u�W�F�N�g�̃e���v���[�g

    [SerializeField] private StudyPrefab studyPrefab;

    private void Start()
    {
        // Instantiate �𗘗p���ĕ������ė��p����B
        Instantiate(studyPrefab);
    }
}
