using JetBrains.Annotations;
using R3;
using UnityEngine;

public class Vanish : MonoBehaviour
{
    public readonly Subject<Unit> OnVanishEnd = new();

    [UsedImplicitly]
    public void VanishEnd()
    {
        OnVanishEnd.OnNext(Unit.Default);
    }
}
