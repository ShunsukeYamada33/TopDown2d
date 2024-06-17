using UnityEditor.Localization.Plugins.XLIFF.V20;
using UnityEngine;
using VContainer;
using VContainer.Unity;
using R3;

public class GameClearPresenter : IStartable
{
    private GameClearManager _gameClearManager;
    private GameClearPanel _gameClearPanel;

    [Inject]
    public GameClearPresenter(GameClearManager gameClearManager, GameClearPanel gameClearPanel)
    {
        _gameClearManager = gameClearManager;
        _gameClearPanel = gameClearPanel;
    }

    public void Start()
    {
        _gameClearManager.gameClearSubject.Subscribe(data => _gameClearPanel.GameClear(data));
        _gameClearManager.Start();
    }
}
