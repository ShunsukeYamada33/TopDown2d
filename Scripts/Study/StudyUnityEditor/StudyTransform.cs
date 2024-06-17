using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    // Transform
    // �ʒu�A��]�A�T�C�Y�������ꂼ��Vector3�Ŏ����Ă���B

    [SerializeField] private Transform _transform;

    void Start()
    {
        // ���g��Transform�̎擾
        // ���x���擾����͎̂኱�d���̂ŉ��x���g�p����ꍇ�̓��[�J���ϐ��ɂ��ꂽ�ق����悢
        _transform = transform;

        // �ʒu�̕ύX
        Vector3 position = _transform.position;
        position.x = 2;
        position.y = 2;
        _transform.position = position;

        // ��]�̕ύX
        Vector3 rotation = _transform.eulerAngles;
        rotation.x = 100;
        rotation.y = 100;
        _transform.eulerAngles = rotation;

        // �T�C�Y�̕ύX
        Vector3 size = _transform.localScale;
        size.x = 2;
        size.y = 2;
        _transform.localScale = size;
    }
}
