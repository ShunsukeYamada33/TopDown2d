using UnityEngine;

public class RewardScriptable : ScriptableObject
{
    public Sprite icon;
    public string id;
    // �ő�擾��
    public int maxCount;

    public virtual void ApplyEffect(PlayerObject player)
    {
        // ���̃����[�h���擾�����Ƃ��̌���
    }
}
