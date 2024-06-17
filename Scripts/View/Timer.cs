using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time;
    private TextMeshProUGUI timerText;

    private void Awake()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        time += Time.deltaTime;
        var minutes = (time / 60).ToString("00");
        var seconds = (time % 60).ToString("00");

        timerText.text = minutes + ":" + seconds;
    }
}
