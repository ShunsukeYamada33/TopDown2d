using DG.Tweening;
using UnityEngine;

public class DoTweenEvent : MonoBehaviour
{
    [SerializeField] private GameObject gameObject01;

    private void Start()
    {
        gameObject01.transform
            .DOMove(new Vector3(4.0f, 0.0f, 0.0f), 10.0f)
            .OnStart(() => Debug.Log("Start"))
            .OnPlay(() => Debug.Log("OnPlay"))
            .OnUpdate(() => Debug.Log("OnUpdate"))
            .OnPause(() => Debug.Log("OnPause"))
            .OnComplete(() => Debug.Log("OnComplete"))
            .OnStepComplete(() => Debug.Log("OnStepComplete"))
            .OnKill(() => Debug.Log("OnKill"));

        // OnStart         動作開始時に1度だけ
        // OnPlay          動作開始時に毎回
        // OnUpdate        動作開始中に毎フレーム(Updateのタイミング)
        // OnPause         動作停止時に毎回
        // OnComplete      動作完了時に1度だけ
        // OnStepComplete  動作完了時にに毎回(ループするたびに)
        // OnKill          動作を破棄したときに1度だけ

    }
}
