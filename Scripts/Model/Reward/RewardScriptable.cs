using UnityEngine;

public class RewardScriptable : ScriptableObject
{
    public Sprite icon;
    public string id;
    // 最大取得数
    public int maxCount;

    public virtual void ApplyEffect(PlayerObject player)
    {
        // このリワードを取得したときの効果
    }
}
