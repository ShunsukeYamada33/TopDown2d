using UnityEngine;

public class StudyOnCollision : MonoBehaviour
{
    void Start()
    {
        
    }

    // �ڐG�������Ƃ��X�N���v�g�Ŏ擾������@
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // tag �𗘗p�����m�F
        if (collision.gameObject.CompareTag("Player"))
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
        StudyOnCollision studyOnCollision = collision.gameObject.GetComponent<StudyOnCollision>();
        if (studyOnCollision != null)
        {
            Debug.Log("StudyOnCollision �ƐڐG������");
        }
    }

    // �ڐG���Ă���Ԃ�����
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("Stay");
    }

    // �ڐG���I��������
    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("Exit");
    }
}
