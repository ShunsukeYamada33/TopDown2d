using Cysharp.Threading.Tasks;
using UnityEngine;

public class StudyUniTask : MonoBehaviour
{
    // UniTask
    // UniTask     ��{�̔񓯊����\�b�h�̖߂�l�̌^
    // UniTask<>   �񓯊�������������ɖ߂�l���󂯎��
    // UniTaskVoid �񓯊������̊�����҂ĂȂ��߂�l�̌^(await �ł��Ȃ�)

    private void Start()
    {
        // Forget �񓯊������̊�����҂��Ȃ�
        Method01().Forget();

        // UniTaskVoid�� await �ł��Ȃ�
        // await Method01();
    }

    private async UniTaskVoid Method01()
    {
        // �񓯊������̊�����ɖ߂�l���󂯎��
        var message = await Method02();
    }

    // UniTask<> �񓯊������̊�����ɖ߂�l��Ԃ��B
    private async UniTask<string> Method02()
    {
        await UniTask.WaitForSeconds(1.0f);
        return "����";
    }
}
