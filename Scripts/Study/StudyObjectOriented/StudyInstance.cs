using UnityEngine;

public class StudyInstance : MonoBehaviour
{
    // instance �C���X�^���X
    // �N���X�͐݌v�}
    // �C���X�^���X�̓N���X������ꂽ "����"

    void Start()
    {
        // Character �͐݌v�}
        // warrior, wizard �C���X�^���X
        // �݌v�}������ꂽ���ۂ̃L�����N�^�[
        // ���܂Ŏg�p���Ă��� new �Ƃ����͎̂�������邱�� �C���X�^���X��
        Character warrior = new Character();
        Character wizard = new Character();
    }

    class Character
    {

    }
}
