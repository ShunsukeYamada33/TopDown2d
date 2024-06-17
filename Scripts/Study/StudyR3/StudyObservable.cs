using R3;
using R3.Triggers;
using UnityEngine;
using UnityEngine.UI;

public class StudyObservable : MonoBehaviour
{
    // Observable
    // ���̑���Subscribe�ł������

    private void Start()
    {
        // 5�b���1�񂾂����������s
        Observable.Timer(System.TimeSpan.FromSeconds(5.0f)).Subscribe(Log);

        // Update�̃^�C�~���O�Ŏ��s��������
        // Unity�̃C�x���g�n�͑S���g����͂� ����AsObservable()
        gameObject.UpdateAsObservable().Subscribe(Log);

        var button = GetComponent<Button>();
        button.OnClickAsObservable().Subscribe(Log);
    }

    private void Log(Unit _)
    {
        Debug.Log("");
    }
}
