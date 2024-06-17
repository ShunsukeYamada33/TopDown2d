using System;
using UnityEngine;

public class StudyFormatSpecifier : MonoBehaviour
{
    // �����w��q
    // �������w�肵�ĕ�������փf�[�^��}�����邽�߂Ɏg�p

    // ����
    // 4��0����  10 �� 0010
    // ����2��   10 �� 10.00
    // �p�[�Z���g 10 �� 1000.00%

    // �����R���
    // String.Format(����, ���l1, ���l2,...);
    // (���l).ToString(����);
    // ������⊮�� interpolation
    private void Start()
    {
        var number = 1234.567;

        // String.Format
        // �}���������f�[�^��{}�ň͂�
        // {0} �P��
        // {1} �Q��
        // �����̃f�[�^����x�Ƀt�H�[�}�b�g�ł���
        Debug.Log(String.Format("Number is {0}", number));

        // ToString()
        // �P��̃f�[�^���t�H�[�}�b�g����ۂɂ����p
        Debug.Log("Number is " + number.ToString());

        // ������⊮�� interpolation
        // �R�[�h�̓ǂ݂₷���ƃ����e�i���X��������
        Debug.Log($"Number is {number}");


        // �t�H�[�}�b�g�̎w��
        // N ���l Number  1,234.567
        // ���̐����͏����ȉ��̌��� N2 1,234.57
        Debug.Log(String.Format("N2 is {0:N2}", number));
        Debug.Log(String.Format("N2 is " + number.ToString("N2")));

        // F �Œ菬���_ Fixed-point 1234,567
        // F2 1234.57
        Debug.Log(String.Format("F2 is {0:F2}", number));
        Debug.Log(String.Format("F2 is " + number.ToString("F2")));

        // P �p�[�Z���e�[�W Percent 
        // P2 123,456.70%
        Debug.Log(String.Format("P2 is {0:P2}", number));
        Debug.Log(String.Format("P2 is " + number.ToString("P2")));

        var numberInt = 123;
        // D 10�i�� Decimal
        // �����̂ݗ��p�\
        // D5 �w�肳�ꂽ�����ɖ����Ȃ��ꍇ�͍����Ƀ[�����ǉ��@00123
        Debug.Log(String.Format("D5 is {0:D5}", numberInt));
        Debug.Log(String.Format("D5 is " + numberInt.ToString("D5")));
    }

    // �ʉ݁A16�i���A�w��
    // ���t�A�����̃t�H�[�}�b�g������
}
