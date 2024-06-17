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

        // OnStart         ����J�n����1�x����
        // OnPlay          ����J�n���ɖ���
        // OnUpdate        ����J�n���ɖ��t���[��(Update�̃^�C�~���O)
        // OnPause         �����~���ɖ���
        // OnComplete      ���슮������1�x����
        // OnStepComplete  ���슮�����ɂɖ���(���[�v���邽�т�)
        // OnKill          �����j�������Ƃ���1�x����

    }
}
