using R3;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class StudyAddTo : MonoBehaviour
{
    // AddTo
    // Subscribe�͑Ώۂ̃t�B�[���h�̃N���X���j������Ă��j������Ȃ��B
    // AddTo�ŃQ�[���I�u�W�F�N�g�ɕR�Â��邱�Ƃ��K�{

    private Subject<int> subjectInt = new();

    private void Method01()
    {
        subjectInt.Subscribe(x => Debug.Log(x)).AddTo(gameObject);
    }
}
