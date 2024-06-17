using UnityEngine;
using UnityEngine.Rendering.Universal;

public class StudyLight : MonoBehaviour
{
    // Light

    private Light2D _light;

    private void Awake()
    {
        _light = GetComponent<Light2D>();
    }

    private void Start()
    {
        _light.color = Color.white;
    }
}
