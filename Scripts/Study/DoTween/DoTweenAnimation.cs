using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class DoTweenAnimation : MonoBehaviour
{
    // ��{�I�ȃA�j���[�V����

    [SerializeField] private GameObject gameObject01;
    [SerializeField] private GameObject gameObject02;
    [SerializeField] private GameObject gameObject03;
    [SerializeField] private GameObject gameObject04;
    [SerializeField] private GameObject gameObject05;

    private Image image01;

    private void Start()
    {
        // Transform �ɑ΂��Ďg�p�ł���B
        // ��{�I�ɍŏ��͈ړ���A�ړ���
        // �Ō�͎���

        gameObject01.transform.DOMove(new Vector3(4.0f, 4.0f, 0.0f), 10.0f);
        gameObject02.transform.DOMoveX(4.0f, 10.0f);
        gameObject03.transform.DOJump(new Vector3(4.0f, 0.0f, 0.0f), 1.0f, 6, 10.0f);
        gameObject04.transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 10.0f);
        gameObject05.transform.DORotate(new Vector3(0.0f, 0.0f, 180.0f), 10.0f);

        // SpriteRenderer
        // RigidBody2D
        // RectTransform 
        // Image
        // ScrollRect
        // Slider ���X

        // TextMeshProUGUI �͗L��

        if (image01 != null)
        {
            image01.DOColor(Color.white, 10.0f);
            image01.DOFade(0.0f, 10.0f);
            image01.DOFillAmount(0.0f, 10.0f);

        }

        // https://dotween.demigiant.com/documentation.php
    }
}
