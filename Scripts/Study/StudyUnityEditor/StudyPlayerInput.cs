using UnityEngine;
using UnityEngine.InputSystem;

public class StudyPlayerInput : MonoBehaviour
{
    // PlayerInput
    // �v���C���[�̓��͂��󂯎��R���|�[�l���g

    // InputActions�Őݒ肵���l���󂯎���ď����̎��s�Ȃǂ��ł���B

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Start()
    {
        // ���͂��ꂽ�Ƃ��̏�����o�^
        // performed ���͂̊J�n
        _playerInput.actions["Move"].performed += OnMove;
        // canceled  ���͂̏I��
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
