using UnityEngine;
using System;

[CreateAssetMenu(fileName = "AddHealth", menuName = "Reward/AddHealth")]
[Serializable]
public class RewardAddHealthScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // ���̃����[�h���擾�����Ƃ��̌���
        player.health++;
    }
}
