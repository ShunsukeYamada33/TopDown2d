using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class StudyContentSizeFitter : MonoBehaviour
{
    // ContentSizeFitter
    // RectTransformを子供の大きさに合わせて自動で変更

    private ScrollRect _scroll;
    [SerializeField] private Transform content;
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] GameObject imagePrefab;

    private void Awake()
    {
        _scroll = GetComponent<ScrollRect>();
    }

    private void Start()
    {
        playerInput.actions["Jump"].performed += InstantiateImage;
    }

    private void InstantiateImage(InputAction.CallbackContext callback)
    {
        Instantiate(imagePrefab, content);
    }
}
