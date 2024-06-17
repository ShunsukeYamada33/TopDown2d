using DG.Tweening;
using UnityEngine;

public class DoTweenSet : MonoBehaviour
{
    [SerializeField] private GameObject gameObject01;

    private void Start()
    {
        gameObject01.transform
            .DOMove(new Vector3(4.0f, 0.0f, 0.0f), 10.0f)
            .SetEase(Ease.InOutQuart)
            .SetDelay(1.0f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetRelative()
            .SetLink(gameObject01);

            // SetEase       アニメーションの種類  https://easings.net/
            // SetDelay      遅らせて実行
            // SetLoops      (ループ回数(-1は無限), ループタイプ(LoopType.Restart or LoopType.Yoyo or LoopType.Incrementa)
            // SetRelative   相対的な位置に移動させる
            // SetLink       ゲームオブジェクトに対して紐づけて、破壊される。  ※
            // 必ずつけたほうが良い
    }
}
