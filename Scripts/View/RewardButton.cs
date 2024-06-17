using R3;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class RewardButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, ISubmitHandler
{
    public Selectable selectable;
    [SerializeField] private Image icon;
    //[SerializeField] private TextMeshProUGUI description;
    [SerializeField] private LocalizeStringEvent description;

    public readonly Subject<Unit> OnClick = new();

    private void Awake()
    {
        selectable = GetComponent<Selectable>();
    }

    public void SetData(RewardScriptable data)
    {
        icon.sprite = data.icon;
        //description.text = data.id;
        description.StringReference.TableEntryReference = data.id;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        selectable.Select();
    }

    public void OnSubmit(BaseEventData eventData)
    {
        OnClick.OnNext(Unit.Default);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick.OnNext(Unit.Default);
    }
}
