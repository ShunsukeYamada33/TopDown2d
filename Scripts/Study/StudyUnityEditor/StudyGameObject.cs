using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    // GameObject

    [SerializeField] private StudyGameObject study;

    void Start()
    {
        // ���g��GameObject�̎擾���@
        Debug.Log(gameObject);
        Debug.Log(study.gameObject);


        // �Q�[���I�u�W�F�N�g�̖��O
        string gameObjectName = gameObject.name;
        Debug.Log(gameObjectName);
    }
}
