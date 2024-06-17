using DG.Tweening;
using UnityEngine;

public class DoTweenSet : MonoBehaviour
{
    [SerializeField] private GameObject gameObject01;

    private void Start()
    {
        gameObject01.transform
            .DOMove(new Vector3(4.0f, 0.0f, 0.0f), 10.0f)
            .SetEase(Ease.InOutQuart)
            .SetDelay(1.0f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetRelative()
            .SetLink(gameObject01);

            // SetEase       �A�j���[�V�����̎��  https://easings.net/
            // SetDelay      �x�点�Ď��s
            // SetLoops      (���[�v��(-1�͖���), ���[�v�^�C�v(LoopType.Restart or LoopType.Yoyo or LoopType.Incrementa)
            // SetRelative   ���ΓI�Ȉʒu�Ɉړ�������
            // SetLink       �Q�[���I�u�W�F�N�g�ɑ΂��ĕR�Â��āA�j�󂳂��B  ��
            // �K�������ق����ǂ�
    }
}
