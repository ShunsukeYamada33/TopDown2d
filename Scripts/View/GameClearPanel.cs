using R3;
using R3.Triggers;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameClearPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI gameClearText;
    [SerializeField] private Transform content;
    [SerializeField] private RankAndTime rankAndTimePrefab;

    private List<RankAndTime> rankAndTimes = new();

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        gameObject.SetActive(false);
        _image.OnPointerClickAsObservable().Subscribe(_ => SceneManager.LoadScene("StartScene"));
    }

    public void GameClear(GameClearData gameClearData)
    {
        gameObject.SetActive(true);

        gameClearText.text = gameClearData.GameClear ? "Game Clear!" : "Game Over.";

        // ‰Šú‰»
        foreach (var rankAndTime in rankAndTimes)
        {
            Destroy(rankAndTime.gameObject);
        }
        rankAndTimes.Clear();

        // ¡‰ñ‚Ìƒ‰ƒ“ƒLƒ“ƒO‚ğ’Ç‰Á
        for (var i = 0; i < gameClearData.Times.Count; i++)
        {
            var time = gameClearData.Times[i];
            var rankAndTime = Instantiate(rankAndTimePrefab, content);
            rankAndTime.rank.text = (i + 1).ToString();
            rankAndTime.time.text = $"{(int)time / 60:D2}:{(int)time % 60:D2}";
            rankAndTimes.Add(rankAndTime);
        }
    }
}
