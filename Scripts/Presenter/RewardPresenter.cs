using NUnit.Framework;
using R3;
using System.Collections.Generic;
using UnityEngine;
using VContainer;
using VContainer.Unity;

public class RewardPresenter : IStartable
{
    private readonly PlayerObject _playerObject;
    private readonly RewardPanel _rewardPanel;
    private readonly CompositeDisposable _disposable = new();

    [Inject]
    public RewardPresenter(PlayerObject playerObject, RewardPanel rewardPanel)
    {
        _playerObject = playerObject;
        _rewardPanel = rewardPanel;
    }

    public void Start()
    {
        _rewardPanel.gameObject.SetActive(false);
        _playerObject.selectableRewardSubject.Subscribe(ShowReward);
    }

    private void ShowReward(List<RewardScriptable> rewards)
    {
        _rewardPanel.gameObject.SetActive(true);
        _rewardPanel.Selected();

        for (int i = 0; i < _rewardPanel.rewardButtons.Count; i++)
        {
            var rewardButton = _rewardPanel.rewardButtons[i];
            if (i < rewards.Count)
            {
                var reward = rewards[i];
                rewardButton.gameObject.SetActive(true);
                rewardButton.SetData(reward);
                rewardButton.OnClick.Subscribe(_ => ClickReward(reward)).AddTo(_disposable);
            }
            else
            {
                rewardButton.gameObject.SetActive(false);
            }
        }
    }

    private void ClickReward(RewardScriptable reward)
    {
        _playerObject.GetReward(reward);
        _rewardPanel.gameObject.SetActive(false);
        // Subscribe ÇµÇΩÇ±Ç∆ÇèIóπ
        _disposable.Clear();
    }
}
