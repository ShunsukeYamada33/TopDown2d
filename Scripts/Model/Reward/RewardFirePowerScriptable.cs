using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FirePower", menuName = "Reward/FirePower")]
[Serializable]
public class RewardFirePowerScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // このリワードを取得したときの効果
        player.firePower++;
    }
}
