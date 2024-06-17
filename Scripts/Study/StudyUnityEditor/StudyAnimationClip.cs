using UnityEngine;

public class StudyAnimationClip : MonoBehaviour
{
    // Animation Clip
    // アニメーションそのもののこと

    // Unityで2Dアニメーションを行う際によく使われる
    // Animation Clip       アニメーションそのもの
    // Animator Controller  アニメーションを切り替えるもの
    // C#スクリプト           Animator Controllerを操作



    // 編集するには紐づいたゲームオブジェクトを選択する必要がある。

    // アニメーション中にイベントを指定して処理を実行することができる
    public void AnimationEnd()
    {
        Debug.Log("AnimationEnd");
    }
}
