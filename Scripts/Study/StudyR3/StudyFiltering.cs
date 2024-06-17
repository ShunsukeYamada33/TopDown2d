using R3;
using UnityEngine;

public class StudyFiltering : MonoBehaviour
{
    // �t�B���^�����O
    // �ʒm���󂯎��ۂ̏������w��ł���
    private Subject<int> subject = new();

    private void Start()
    {
        // Where
        // �����𖞂��������̂ݏ���
        subject.Where(x => x < 10).Subscribe();

        // DistinctUntilChanged
        // �O��̒l�Ɠ����ꍇ�͎Ւf���A�قȂ�ꍇ�̂ݏ���
        subject.DistinctUntilChanged().Subscribe();

        // Skip
        // �ŏ���n�񕪖�������
        // ReactiveProperty�̏�����s�������Ȃ��ꍇ�ɂ悭���s
        subject.Skip(1).Subscribe();

        // Take
        // �ŏ���n�񂾂�����
        subject.Take(1).Subscribe();

        // Select
        // �󂯎�����l��ϊ����ď���
        subject.Select(x => x * 2).Subscribe();
    }
}
