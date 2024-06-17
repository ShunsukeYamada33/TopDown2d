using UnityEngine;
using UnityEngine.InputSystem;

public class StudyPlayerInput : MonoBehaviour
{
    // PlayerInput
    // プレイヤーの入力を受け取るコンポーネント

    // InputActionsで設定した値を受け取って処理の実行などができる。

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        // 入力されたときの処理を登録
        // performed 入力の開始
        _playerInput.actions["Move"].performed += OnMove;
        // canceled  入力の終了
        _playerInput.actions["Move"].canceled += OnMove;
    }

    private void OnMove(InputAction.CallbackContext callback)
    {
        Vector2 value = callback.ReadValue<Vector2>();
        var position = transform.position;
        position.x += value.x;
        position.y += value.y;
        transform.position = position;
    }
}
