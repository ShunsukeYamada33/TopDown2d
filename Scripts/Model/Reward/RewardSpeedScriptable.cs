using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Speed", menuName = "Reward/Speed")]
[Serializable]
public class RewardSpeedScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // このリワードを取得したときの効果
        player.speed++;
    }
}
