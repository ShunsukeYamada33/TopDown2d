using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    // Component �R���|�[�l���g
    // �Q�[���I�u�W�F�N�g�ɕt���@�\�̂���

    // Attack, Take, Move �R���|�[�l���g������
    // Attack, Take, Move ��{�̃L�����N�^�[
    // Take               ��
    // Attack, Move       ���G�L�����N�^�[
    // Attack, Take       �Œ�C��

    // �R���|�[�l���g�̑g�ݍ��킹�ŐU�镑�����ς�����

    // MonoBehaviour ���p���������̂̂ݕt������

    private void Start()
    {
        // �R���|�[�l���g�̒ǉ�
        var addComponent = gameObject.AddComponent<StudyComponent>();

        // �R���|�[�l���g�̎擾
        var getComponent = gameObject.GetComponent<StudyComponent>();
    }
}
