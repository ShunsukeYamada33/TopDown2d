using UnityEngine;

public class StudyColor : MonoBehaviour
{
    public Color test01;

    void Start()
    {
        // 初期化  
        //Color test02 = new Color();
        // R（赤) G(緑) B(青) 透明度をそれぞれ 0.0f ~ 1.0f;
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
