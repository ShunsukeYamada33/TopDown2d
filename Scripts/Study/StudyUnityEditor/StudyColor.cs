using UnityEngine;

public class StudyColor : MonoBehaviour
{
    public Color test01;

    void Start()
    {
        // ������  
        //Color test02 = new Color();
        // R�i��) G(��) B(��) �����x�����ꂼ�� 0.0f ~ 1.0f;
        Color test03 = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        Color test07 = new Color(1.0f, 1.0f, 1.0f);

        test03.r = 1.0f;
        test03.g = 1.0f;
        test03.b = 1.0f;
        test03.a = 1.0f;

        Color test04 = Color.white;
        Color test05 = Color.blue;
        Color test06 = Color.red;
    }
}
