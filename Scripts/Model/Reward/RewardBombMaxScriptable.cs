using System;
using UnityEngine;

[CreateAssetMenu(fileName = "BombMax", menuName = "Reward/BombMax")]
[Serializable]
public class RewardBombMaxScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // ‚±‚ÌƒŠƒ[ƒh‚ğæ“¾‚µ‚½‚Æ‚«‚ÌŒø‰Ê
        player.bombMax++;
    }
}
