using UnityEngine;

public class StudyOnTrigger : MonoBehaviour
{
    void Start()
    {
        
    }

    // Triggerの場合は接触してくる者にRigidBody2dは不要

    // コライダーがIsTrigerのオブジェクト接触したことをスクリプトで取得する方法
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // tag を利用した確認
        if (collision.CompareTag("Player"))
        {
            Debug.Log("tag が Player と接触したよ");
        }

        // layer を利用した確認
        int layer = collision.gameObject.layer;
        // thisLayer = gameObject.layer;
        if (layer == 0)
        {
            Debug.Log("layer が 0 と接触したよ");
        }

        // 少しだけ重い処理です。　GetComponent<>
        StudyOnCollision studyOnCollision = collision.GetComponent<StudyOnCollision>();
        if (studyOnCollision != null)
        {
            Debug.Log("StudyOnCollision と接触したよ");
        }
    }

    // 接触している間ずっと
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Stay");
    }

    // 接触が終了した時
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
    }
}
