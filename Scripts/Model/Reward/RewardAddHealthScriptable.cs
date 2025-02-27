using UnityEngine;
using System;

[CreateAssetMenu(fileName = "AddHealth", menuName = "Reward/AddHealth")]
[Serializable]
public class RewardAddHealthScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // このリワードを取得したときの効果
        player.health++;
    }
}
