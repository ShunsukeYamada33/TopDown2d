using UnityEngine;

public class StudyLambda : MonoBehaviour
{
    // Lambda �����_

    // ���\�b�h���ꎞ�I�ɍ쐬������@

    private delegate void MyDelegate01();
    private delegate void MyDelegate02(string text);
    private delegate void MyDelegate03(string text01, string text02);
    private delegate string MyDelegate04(string text01, string text02);

    private void Method()
    {
        // ��{�I�ȋL�q
        // ���� => �E��

        // (�����P, ....) => ����;
        MyDelegate01 myDelegate01 = () => Debug.Log("�����_");
        MyDelegate02 myDelegate02 = (argument) => Debug.Log(argument);
        // MyDelegate02 myDelegate02 = argument => Debug.Log(argument);
        MyDelegate03 myDelegate03 = (argument01, argument02) => Debug.Log(argument01 + argument02);


        // (�����P, ....) =>
        // {
        //    ����
        // };

        MyDelegate01 myDelegate05 = () =>
        {
            Debug.Log("����1");
            Debug.Log("����2");
            Debug.Log("����3");
        };

        // �߂�l����̏ꍇ
        MyDelegate04 myDelegate04 = (argument01, argument02) => { return argument01 + argument02; };

        // �����o���Ă��悢����
        // () => {};
        // MyDelegate01 myDelegate01 = () => { Debug.Log("�����_"); };
        // MyDelegate02 myDelegate02 = (argument) => { Debug.Log(argument); };
        // MyDelegate03 myDelegate03 = (argument01, argument02) => { Debug.Log(argument01 + argument02); };
    }
}
