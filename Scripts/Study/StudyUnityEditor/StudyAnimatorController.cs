using UnityEngine;

public class StudyAnimatorController : MonoBehaviour
{
    // Animator Controller
    // �A�j���[�V������؂�ւ������

    // Unity��2D�A�j���[�V�������s���ۂɂ悭�g����
    // Animation Clip       �A�j���[�V�������̂���
    // Animator Controller  �A�j���[�V������؂�ւ������
    // C#�X�N���v�g           Animator Controller�𑀍�

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        // Set����(�p�����[�^��, �l);
        _animator.SetFloat("Speed", 1.1f);
        _animator.SetTrigger("Attack");
    }
}
