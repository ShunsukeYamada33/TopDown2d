using R3;
using UnityEngine;

public class StudySubject : MonoBehaviour
{
    // Subject

    // ���A�N�e�B�u�v���O���~���O�Ƃ�
    // �����l���ύX�����ƁA�����ŉ������������s����B
    // �G�L�����N�^�[�����S����ƁA�}�b�v�̃L�����N�^�[�̎c��m�̂Ƃ������\���̐؂�ւ��A�|�����G�̓��v�f�[�^���C���N�������g����

    // ���A�N�e�B�u�v���O���~���O�Ŋ�{�̋@�\
    // Subject    �ʒm����N���X
    // OnNext     �ʒm����
    // Subscribe  �ʒm���󂯎��

    // ���l��Y���Ēʒm����
    private Subject<int> subjectInt = new();

    // ���ɉ��̒l���Ȃ��ɒʒm��������B
    private Subject<Unit> subjectUnit = new();

    private void Method01()
    {
        // �ʒm���󂯎�邱�Ƃ�錾����B .Subscribe(�f���[�Q�[�g);
        subjectInt.Subscribe(x => Debug.Log(x));
        subjectInt.Subscribe(DebugInt);

        subjectUnit.Subscribe(_ => Debug.Log("�ʒm"));


        // �ʒm����
        subjectInt.OnNext(1);
        subjectUnit.OnNext(Unit.Default);
    }

    private void DebugInt(int x)
    {
        Debug.Log(x);
    }

    // 1
    // 1
    // �ʒm


    // ���p��
    // ���̃N���X��OnNext�����ƍ���B
    // ���̃N���X��Subscribe�����ƍ���ꍇ�̃e�N�j�b�N

    // �ʒm���󂯂�@�\���������J���� .Subscribe
    public Observable<int> ObservableInt => subjectInt;

    // �ʒm����@�\�����J���� .OnNext
    public ISubject<int> ISubjectInt => subjectInt;

    public void Method02()
    {
        ObservableInt.Subscribe(x => Debug.Log(x));

        ISubjectInt.OnNext(1);
    }
}
