using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Speed", menuName = "Reward/Speed")]
[Serializable]
public class RewardSpeedScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // ‚±‚ÌƒŠƒ[ƒh‚ğæ“¾‚µ‚½‚Æ‚«‚ÌŒø‰Ê
        player.speed++;
    }
}
