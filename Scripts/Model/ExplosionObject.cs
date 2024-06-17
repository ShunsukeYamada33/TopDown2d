using JetBrains.Annotations;
using R3;
using UnityEngine;

public class ExplosionObject : MonoBehaviour
{
    public readonly Subject<Unit> OnExplosionEnd = new();

    [UsedImplicitly]
    public void ExplosionEnd()
    {
        OnExplosionEnd.OnNext(Unit.Default);
    }
}
