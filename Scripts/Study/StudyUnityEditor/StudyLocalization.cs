using UnityEngine;
using UnityEngine.Localization.Components;

public class StudyLocalization : MonoBehaviour
{
    // Localization ������Ή�

    [SerializeField] private LocalizeStringEvent text;
    [SerializeField] private LocalizeSpriteEvent sprite;

    private void Start()
    {
        // �e�L�X�g�̑�����Ή��p�̃L�[�𓮓I�ɐݒ肷����@
        text.StringReference.TableEntryReference = "Localization";
        // �摜�̑�����Ή��p�̃L�[�𓮓I�ɐݒ肷����@
        sprite.AssetReference.TableEntryReference = "Localization";
    }
}
