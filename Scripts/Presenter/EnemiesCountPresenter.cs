using ObservableCollections;
using R3;
using TMPro;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class EnemiesCountPresenter : IStartable
{
    private MapManager _mapManager;
    private TextMeshProUGUI _enemiesCountText;

    [Inject]
    public EnemiesCountPresenter(MapManager mapManager, TextMeshProUGUI enemiesCountText)
    {
        _mapManager = mapManager;
        _enemiesCountText = enemiesCountText;
    }

    public void Start()
    {
        _mapManager.enemies
            .ObserveCountChanged()
            .Subscribe(count => _enemiesCountText.text = count.ToString())
            .AddTo(_mapManager.gameObject);
    }
}
