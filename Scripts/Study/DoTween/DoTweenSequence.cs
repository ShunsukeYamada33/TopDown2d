using DG.Tweening;
using UnityEngine;

public class DoTweenSequence : MonoBehaviour
{
    [SerializeField] private GameObject gameObject01;

    private void Start()
    {
        // シーケンス生成
        var sequence = DOTween.Sequence();

        sequence
            .Append(gameObject01.transform.DOMoveX(0, 10.0f))
            .Append(gameObject01.transform.DOMoveY(2, 10.0f))
            .Join(gameObject01.transform.DOMoveX(2, 10.0f))
            .Insert(5.0f, gameObject01.transform.DOMoveY(0.0f, 5.0f))
            .Prepend(gameObject01.transform.DOMove(new Vector3(-2.0f, -2.0f, 0.0f), 10.0f));

        // Append   前回のアニメーションの後にアニメーションさせる
        // Join     前回のアニメーションと同じタイミングにアニメーションさせる
        // Insert   前回のアニメーションと遅らせてアニメーションさせる
        // Prepend  一番最初にアニメーションさせる。他のアニメーションをその時間分遅らせる

        sequence.Play();
        sequence.Pause();
        sequence.Kill();
        sequence.Complete();

        // Play     開始
        // Pause    止める
        // Kill     破棄
        // Complete 完了させる
    }
}
