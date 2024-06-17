using DG.Tweening;
using UnityEngine;

public class DoTweenSequence : MonoBehaviour
{
    [SerializeField] private GameObject gameObject01;

    private void Start()
    {
        // �V�[�P���X����
        var sequence = DOTween.Sequence();

        sequence
            .Append(gameObject01.transform.DOMoveX(0, 10.0f))
            .Append(gameObject01.transform.DOMoveY(2, 10.0f))
            .Join(gameObject01.transform.DOMoveX(2, 10.0f))
            .Insert(5.0f, gameObject01.transform.DOMoveY(0.0f, 5.0f))
            .Prepend(gameObject01.transform.DOMove(new Vector3(-2.0f, -2.0f, 0.0f), 10.0f));

        // Append   �O��̃A�j���[�V�����̌�ɃA�j���[�V����������
        // Join     �O��̃A�j���[�V�����Ɠ����^�C�~���O�ɃA�j���[�V����������
        // Insert   �O��̃A�j���[�V�����ƒx�点�ăA�j���[�V����������
        // Prepend  ��ԍŏ��ɃA�j���[�V����������B���̃A�j���[�V���������̎��ԕ��x�点��

        sequence.Play();
        sequence.Pause();
        sequence.Kill();
        sequence.Complete();

        // Play     �J�n
        // Pause    �~�߂�
        // Kill     �j��
        // Complete ����������
    }
}
