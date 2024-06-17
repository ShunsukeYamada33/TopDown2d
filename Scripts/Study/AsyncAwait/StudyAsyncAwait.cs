using Cysharp.Threading.Tasks;
using DG.Tweening;
using R3;
using UnityEngine;

public class StudyAsyncAwait : MonoBehaviour
{
    // �񓯊�����
    // ����̏������I������܂ő҂B

    // async   �񓯊��̃��\�b�h�ł���Ɛ錾
    // await   ���\�b�h���ő҂�
    // UniTask Unity�ł̔񓯊������̖߂�l�̌^

    private Subject<Unit> subject = new Subject<Unit>();

    private void Start()
    {
        // Forget �񓯊������̊�����҂��Ȃ�
        Method01().Forget();
    }


    // �񓯊����������郁�\�b�h�ł��Ƃ����錾 async
    // �A�N�Z�X�C���q async �߂�l�^ ���\�b�h��(����1�^ ����1, ......)
    private async UniTask Method01()
    {
        // 1�b�҂�
        await UniTask.WaitForSeconds(1.0f);

        // ���̔񓯊�������҂B�߂�l�̌^�� UniTask
        await Method02();

        // Forget �񓯊������̊�����҂��Ȃ�
        Method02().Forget();

        // DoTween�̃A�j���[�V�����̊�����҂� AsyncWaitForCompletion
        await transform.DOMove(new Vector3(1.0f, 1.0f, 0.0f), 1.0f).AsyncWaitForCompletion();

        // R3��Subject�ɑ΂��ŏ��� OnNext() �����܂ő҂�
        await subject.FirstAsync();

        // �L�����Z������������͎�舵��Ȃ������
    }

    private async UniTask Method02()
    {
        await UniTask.WaitForSeconds(1.0f);
    }
}
