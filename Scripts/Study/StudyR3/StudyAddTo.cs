using R3;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class StudyAddTo : MonoBehaviour
{
    // AddTo
    // Subscribeは対象のフィールドのクラスが破棄されても破棄されない。
    // AddToでゲームオブジェクトに紐づけることが必須

    private Subject<int> subjectInt = new();

    private void Method01()
    {
        subjectInt.Subscribe(x => Debug.Log(x)).AddTo(gameObject);
    }
}
