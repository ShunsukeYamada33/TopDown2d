using UnityEngine;

public class StudyVector : MonoBehaviour
{
    // Vector

    public Vector2 vector2 = new Vector2();
    public Vector2Int vector2Int = new Vector2Int();
    public Vector3 vector3 = new Vector3();
    public Vector3Int vector3Int = new Vector3Int();

    // �R�̃X�e�[�^�X���������^
    // �ʒu�Ȃǂ𗘗p����ۂɕ֗�

    void Start()
    {
        // ���
        vector2.x = 10;
        vector3.z = 10;

        // ������
        Vector2 test01 = new Vector2();
        Vector2 test02 = new Vector2(10, 10);
        Vector3 test03 = new Vector3(10, 10, 10);
        test01.x = 5;
        test01.y = 5;

        // �����^�Ȃ�v�Z�ł���B
        vector2 = test01 + test02;
        vector3 = test03 + new Vector3(3, 3, 3);


        //�g����
        Debug.Log(vector2);
        Debug.Log(vector2.x);

        Debug.Log(vector3);
        Debug.Log(vector3.x);
    }
}
