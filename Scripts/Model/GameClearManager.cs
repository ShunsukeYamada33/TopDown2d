using ObservableCollections;
using R3;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VContainer;

public class GameClearManager
{
    private PlayerObject _playerObject;
    private MapManager _mapManager;
    private ISaveData _saveData;
    private Timer _timer;
    public Subject<GameClearData> gameClearSubject = new();

    [Inject]
    public GameClearManager(PlayerObject playerObject, MapManager mapManager, ISaveData saveData
        , Timer timer)
    {
        _playerObject = playerObject;
        _mapManager = mapManager; 
        _saveData = saveData;
        _timer = timer;
    }

    public void Start()
    {
        _playerObject.OnVanish.Subscribe(GameOver);
        _mapManager.enemies.ObserveCountChanged().Where(count => count <= 0).Subscribe(GameClear);
    }

    private void GameOver(Unit _)
    {
        var data = Load();
        var gameClearData = new GameClearData(false, data);
        gameClearSubject.OnNext(gameClearData);
    }

    private void GameClear(int _)
    {
        var data = Save(_timer.time); // TODO
        var gameClearData = new GameClearData(true, data);
        gameClearSubject.OnNext(gameClearData);
    }

    private static string key = "ClearTime";

    private List<float> Load()
    {
        var jsonData = _saveData.Load(key);
        var clearTime = JsonUtility.FromJson<ClearTimeData>(jsonData);
        if (clearTime == null) clearTime = new ClearTimeData();
        return clearTime.times;
    }

    private List<float> Save(float score)
    {
        var clearTime = new ClearTimeData();
        // —ð‘ã‚Ì‹L˜^‚ðŽæ“¾
        var data = Load();
        data.Add(score);

        // ‘‚¢‡‚É•À‚×‚é(¸‡)Å‘å‚Q‚O‚Ü‚Å
        clearTime.times = data.OrderBy(time => time).Take(20).ToList();

        var jsonData = JsonUtility.ToJson(clearTime);
        _saveData.Save(key, jsonData);

        return clearTime.times;
    }
}
