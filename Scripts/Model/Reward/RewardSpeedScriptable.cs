using System;
using UnityEngine;

[CreateAssetMenu(fileName = "Speed", menuName = "Reward/Speed")]
[Serializable]
public class RewardSpeedScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // ���̃����[�h���擾�����Ƃ��̌���
        player.speed++;
    }
}
