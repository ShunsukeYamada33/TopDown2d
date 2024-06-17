using UnityEngine;

public class StudyOnTrigger : MonoBehaviour
{
    void Start()
    {
        
    }

    // Trigger�̏ꍇ�͐ڐG���Ă���҂�RigidBody2d�͕s�v

    // �R���C�_�[��IsTriger�̃I�u�W�F�N�g�ڐG�������Ƃ��X�N���v�g�Ŏ擾������@
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // tag �𗘗p�����m�F
        if (collision.CompareTag("Player"))
        {
            Debug.Log("tag �� Player �ƐڐG������");
        }

        // layer �𗘗p�����m�F
        int layer = collision.gameObject.layer;
        // thisLayer = gameObject.layer;
        if (layer == 0)
        {
            Debug.Log("layer �� 0 �ƐڐG������");
        }

        // ���������d�������ł��B�@GetComponent<>
        StudyOnCollision studyOnCollision = collision.GetComponent<StudyOnCollision>();
        if (studyOnCollision != null)
        {
            Debug.Log("StudyOnCollision �ƐڐG������");
        }
    }

    // �ڐG���Ă���Ԃ�����
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Stay");
    }

    // �ڐG���I��������
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
    }
}
