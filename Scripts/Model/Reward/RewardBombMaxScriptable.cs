using System;
using UnityEngine;

[CreateAssetMenu(fileName = "BombMax", menuName = "Reward/BombMax")]
[Serializable]
public class RewardBombMaxScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // このリワードを取得したときの効果
        player.bombMax++;
    }
}
