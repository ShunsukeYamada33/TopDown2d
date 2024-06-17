using Unity.VisualScripting;
using UnityEngine;

public class StudySingleton : MonoBehaviour
{
    // �V���O���g�� Singleton
    // �C���X�^���X��1�������݂��Ȃ����Ƃ�ۏ؂���


    // �V���O���g���C���X�^���X
    // �O������Q�Ƃł���悤�ɂ��邽�߂� public static �Ő錾
    // �v���p�e�B�ŊO������̕ύX���֎~
    public static StudySingleton Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            // �V�[����؂�ւ��Ă��I�u�W�F�N�g���j������Ȃ��悤�ɂ���
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // ���ɃC���X�^���X�����݂���ꍇ�͍폜
            Destroy(gameObject);
        }
    }

    public float timer { get; private set; }

    private void Update()
    {
        timer += Time.deltaTime;
    }

    // �Q�[�����J�n���Ă���̌o�ߎ��Ԃ����ł��擾�ł���悤�ɂȂ�B
}
