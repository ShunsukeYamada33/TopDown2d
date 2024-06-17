using UnityEngine;
using UnityEngine.InputSystem;

public class StudyCinemachine : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    private Vector2 speed;
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    private void Start()
    {
        playerInput.actions["Move"].performed += OnMove;
        playerInput.actions["Move"].canceled += OnMove;
    }

    private void FixedUpdate()
    {
        var position = _transform.position;
        position.x += speed.x;
        position.y += speed.y;
        _transform.position = position;
    }

    private void OnMove(InputAction.CallbackContext callback)
    {
        speed = callback.ReadValue<Vector2>();
    }
}
