using R3;
using UnityEngine;

public class StudyReactiveProperty : MonoBehaviour
{
    // ReactiveProperty

    // ���A�N�e�B�u�v���O���~���O�Ƃ�
    // �����l���ύX�����ƁA�����ŉ������������s����B
    // HP���ω�����ƁA�����ŃX���C�_�[��ς���B

    public ReactiveProperty<int> reactivePropertyInt = new(100);

    private void Start()
    {
        reactivePropertyInt.Subscribe(x => Debug.Log(x));
        reactivePropertyInt.Subscribe(DebugInt);

        // �l��ύX����ꍇ��.Value��ς���
        // �l��ς���ƒʒm
        reactivePropertyInt.Value = 10;
    }

    private void DebugInt(int integer)
    {
        Debug.Log(integer);
    }

    // 10
    // 10




    // ���p��
    // ���̃N���X�Ő��l��ς�����ƍ���B

    // �ʒm���󂯂�@�\���������J���� .Subscribe
    public ReadOnlyReactiveProperty<int> ReactivePropertyInt => reactivePropertyInt;

    public void Method02()
    {
        ReactivePropertyInt.Subscribe(x => Debug.Log(x));
    }



}
