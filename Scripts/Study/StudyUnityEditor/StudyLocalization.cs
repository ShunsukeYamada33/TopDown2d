using UnityEngine;
using UnityEngine.Localization.Components;

public class StudyLocalization : MonoBehaviour
{
    // Localization 多言語対応

    [SerializeField] private LocalizeStringEvent text;
    [SerializeField] private LocalizeSpriteEvent sprite;

    private void Start()
    {
        // テキストの多言語対応用のキーを動的に設定する方法
        text.StringReference.TableEntryReference = "Localization";
        // 画像の多言語対応用のキーを動的に設定する方法
        sprite.AssetReference.TableEntryReference = "Localization";
    }
}
