using UnityEngine;

public class StudyProperties : MonoBehaviour
{
    // �v���p�e�B
    // �t�B�[���h�̌��J���@�̏ڍׂ�ݒ�ł���

    // �t�B�[���h�̈����Ƃ��� "�l��ݒ肷��" �� "�l���擾����" ������B
    // "�l��ݒ肷��" �������J�ȂǏڍׂ�ݒ�ł���B

    private class Character01
    {
        public string name;
    }

    private void UseCharacter01()
    {
        Character01 character = new Character01();
        // �l��ݒ肷��
        character.name = "���O";
        // �l���擾����
        string name = character.name;
        Debug.Log(name);
    }


    // �� "�l���擾����" �����\�ɂ���B
    // �v���p�e�B�̓������͑啶���ɂ���ق����悢�B
    private class Character02
    {
        public string Name { get; private set; } = "������";
    }

    private void UseCharacter02()
    {
        Character02 character = new Character02();
        // �l��ݒ肷��
        // character.Name = "���O";
        // �l���擾����
        string name = character.Name;
        Debug.Log(name);
    }

    private class Character03
    {
        // ���[�J���ϐ����v���p�e�B�Ƃ��Č��J���ł���
        private string privateName = "�v���C�x�[�g";

        public string Name
        {
            get => privateName;
            set => privateName = value;
        }

        // ���̂悤�Ȍ`�ŏ�����v�Z��������Œl���X�V�A�擾���邱�Ƃ��ł���B
        public int Score
        {
            get
            {
                if (Score <= 0)
                {
                    return 0;
                }
                else
                {
                    return Score;
                }
            }

            set
            {
                if (Score < 1000)
                {
                    Score = value;
                }
                else
                {
                    Score = 1000;
                }
            }
        }
    }
}
