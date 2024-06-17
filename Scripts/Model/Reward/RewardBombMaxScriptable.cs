using System;
using UnityEngine;

[CreateAssetMenu(fileName = "BombMax", menuName = "Reward/BombMax")]
[Serializable]
public class RewardBombMaxScriptable : RewardScriptable
{
    public override void ApplyEffect(PlayerObject player)
    {
        // ���̃����[�h���擾�����Ƃ��̌���
        player.bombMax++;
    }
}
