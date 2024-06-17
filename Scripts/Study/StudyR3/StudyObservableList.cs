using ObservableCollections;
using R3;
using UnityEngine;

public class StudyObservableList : MonoBehaviour
{
    // ObservableList

    // ���A�N�e�B�u�v���O���~���O�Ƃ�
    // ���X�g�̗v�f�A�v�f�����ς��Ǝ����Œʒm����B
    public ObservableList<int> observableList = new();

    public void Method01()
    {
        // �v�f���ǉ����ꂽ�ꍇ�Ɏ��s
        observableList.ObserveAdd().Subscribe(x => Debug.Log(x.Value));
        observableList.ObserveAdd().Subscribe(AddEvent);

        // �v�f���폜���ꂽ�ꍇ�Ɏ��s
        observableList.ObserveRemove().Subscribe(RemoveEvent);

        // �v�f�����ύX���ꂽ�ꍇ�Ɏ��s
        observableList.ObserveCountChanged().Subscribe(CountChanged);

        // �v�f�̒l���㏑�����ꂽ�ꍇ�Ɏ��s
        observableList.ObserveReplace().Subscribe(Replace);

        // ���Z�b�g
        observableList.ObserveReset().Subscribe(ObserveReset);
    }

    // CollectionAddEvent
    private void AddEvent(CollectionAddEvent<int> x)
    {
        Debug.Log(x.Value);
    }

    private void RemoveEvent(CollectionRemoveEvent<int> x)
    {
        Debug.Log(x.Value);
    }

    private void CountChanged(int  count)
    {
        Debug.Log(count);
    }

    private void Replace(CollectionReplaceEvent<int> x)
    {
        Debug.Log(x);
    }

    private void ObserveReset(Unit _)
    {
        Debug.Log("���Z�b�g");
    }
}
