using UnityEngine;

public class StudyTagAndLayer : MonoBehaviour
{
    // Tag    �^�O
    // Layer  ���C���[


    void Start()
    {
        //�^�O�̎擾
        string tag = gameObject.tag;
        Debug.Log(tag);

        // �^�O�̔�r
        bool compareTag = gameObject.CompareTag("Player");

        int layer = gameObject.layer;
        Debug.Log(layer);
    }
}
