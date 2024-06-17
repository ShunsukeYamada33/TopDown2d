using TMPro;
using UnityEngine;
using VContainer;

public class UseWithParameter
{
    private readonly TextMeshProUGUI _text01;
    private readonly TextMeshProUGUI _text02;

    [Inject]
    public UseWithParameter(TextMeshProUGUI text01, TextMeshProUGUI text02)
    {
        _text01 = text01;
        _text02 = text02;
    }
}
