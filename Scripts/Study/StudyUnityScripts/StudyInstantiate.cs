using UnityEngine;

public class StudyInstantiate : MonoBehaviour
{
    // Instantiate �Q�[���I�u�W�F�N�g�̐���

    [SerializeField] GameObject prefab;

    private void Start()
    {
        // �I�u�W�F�N�g�̐���
        var newObject01 = Instantiate(prefab);

        // �e�̎w��
        var newObject02 = Instantiate(prefab, transform);

        // �ʒu�A��]�̎w��
        var position = new Vector3(2, 2, 0);
        var rotation = transform.rotation;
        // Quaternion.identity ��]�Ȃ�
        var newObject03 = Instantiate(prefab, position, Quaternion.identity, transform);
    }
}
