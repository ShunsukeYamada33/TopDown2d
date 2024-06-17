using R3;
using System;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class CharacterPresenter : IStartable
{
    private readonly CharacterModel _characterModel;
    private readonly CharacterView _characterView;

    [Inject]
    public CharacterPresenter(CharacterModel characterModel, CharacterView characterView)
    {
        _characterModel = characterModel;
        _characterView = characterView;
    }

    public void Start()
    {
        _characterModel.Health.Subscribe(ChangeHealth).AddTo(_characterModel.gameObject);
        _characterModel.OnDead.Subscribe(OnDead).AddTo(_characterModel.gameObject);
    }

    private void ChangeHealth(int health)
    {
        _characterView.ChangeSlider(health);
    }

    private void OnDead(Unit _)
    {
        _characterView.ChangeText();
    }
}
