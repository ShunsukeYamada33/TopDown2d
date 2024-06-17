using UnityEngine;

public class StudyTimeDeltaTime : MonoBehaviour
{
    // Time.deltaTime
    // �O��� Update ���ꂽ���Ԃ���o�߂�������(�b)���擾�ł���B

    private float timer;
    private float speed = 1;

    private void Update()
    {
        // Time.deltaTime
        // �O��� Update ���ꂽ���Ԃ���o�߂�������(�b)���擾�ł���B
        Debug.Log(Time.deltaTime);

        timer += Time.deltaTime;
        // �Q�[���I�u�W�F�N�g�������Ă��鎞�Ԃ̍��v
        Debug.Log(timer);


        // �I�u�W�F�N�g�̈ړ��ɂ��g����B
        var position = transform.position;
        position.x += speed * Time.deltaTime;
        transform.position = position;

        // ���� = ���� speed * ���� Time.deltaTime
    }

    private void FixedUpdate()
    {
        var position = transform.position;
        position.x += speed;
        transform.position = position;

        // FixedUpdate�ł͎��Ԃ͈��
    }

    // Update�ňړ��̏����������������炩�ɂȂ�
    // �����Ƃ��Ă� �p�x������ + �v�Z�����G �Ȃ��ߏd��
}
