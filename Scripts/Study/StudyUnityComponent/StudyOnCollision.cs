using UnityEngine;

public class StudyOnCollision : MonoBehaviour
{
    void Start()
    {
        
    }

    // 接触したことをスクリプトで取得する方法
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // tag を利用した確認
        if (collision.gameObject.CompareTag("Player"))
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
        StudyOnCollision studyOnCollision = collision.gameObject.GetComponent<StudyOnCollision>();
        if (studyOnCollision != null)
        {
            Debug.Log("StudyOnCollision と接触したよ");
        }
    }

    // 接触している間ずっと
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log("Stay");
    }

    // 接触が終了した時
    private void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("Exit");
    }
}
