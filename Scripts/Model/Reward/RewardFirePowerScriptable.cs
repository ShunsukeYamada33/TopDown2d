using System;
using UnityEngine;

[CreateAssetMenu(fileName = "FirePower", menuName = "Reward/FirePower")]
[Serializable]
public class RewardFirePowerScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // ���̃����[�h���擾�����Ƃ��̌���
        player.firePower++;
    }
}
