using UnityEngine;

public class StudyLifeCycleUpdate : MonoBehaviour
{
    // ���C�t�T�C�N���C�x���g Update FixUpdate

    // Unity �̃Q�[���I�u�W�F�N�g���������Ɏ��s����鏈��

    private void Update()
    {
        // ���t���[���Ă΂��B

        // �t���[���Ƃ�
        // �������y����΂�������Ă΂��B
        // �������d����ΌĂ΂�鐔������B
        // ���s�^�C�~���O���ω�����B

        // ��{�I�ɂ͂�������Ă΂��B
        // ���[�U�[����̓��͂ɑ΂��g���邱�Ƃ������B
    }

    private void FixedUpdate()
    {
        // �����I�Ȏ���
        // ��莞�Ԃ��ƂɎ��s�����B�^�C�~���O���s��

        // �����I�Ȍv�Z�Ɏg���邱�Ƃ�����

        var position = transform.position;
        position.x += speed;
        transform.position = position;

        // �ݒ���@
        // Editor/Project Settings/Time/Fixed Timestamp
    }

    private float speed = 1;
}
