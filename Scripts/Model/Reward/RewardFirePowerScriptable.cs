using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FirePower", menuName = "Reward/FirePower")]
[Serializable]
public class RewardFirePowerScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // ‚±‚ÌƒŠƒ[ƒh‚ğæ“¾‚µ‚½‚Æ‚«‚ÌŒø‰Ê
        player.firePower++;
    }
}
