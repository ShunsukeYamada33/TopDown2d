using UnityEngine;

public class StudyAnimatorController : MonoBehaviour
{
    // Animator Controller
    // アニメーションを切り替えるもの

    // Unityで2Dアニメーションを行う際によく使われる
    // Animation Clip       アニメーションそのもの
    // Animator Controller  アニメーションを切り替えるもの
    // C#スクリプト           Animator Controllerを操作

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        // Set○○(パラメータ名, 値);
        _animator.SetFloat("Speed", 1.1f);
        _animator.SetTrigger("Attack");
    }
}
