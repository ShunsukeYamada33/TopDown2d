using UnityEngine;

public class RewardScriptable : ScriptableObject
{
    public Sprite icon;
    public string id;
    // Å‘åæ“¾”
    public int maxCount;

    public virtual void ApplyEffect(PlayerObject player)
    {
        // ‚±‚ÌƒŠƒ[ƒh‚ğæ“¾‚µ‚½‚Æ‚«‚ÌŒø‰Ê
    }
}
