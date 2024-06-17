using System;
using UnityEngine;
using VContainer;

public class UseRegisterFactory 
{
    private readonly Func<RegisterFactoryData, IRegisterFactory> _func;

    [Inject]
    public UseRegisterFactory(Func<RegisterFactoryData, IRegisterFactory> func)
    {
        _func = func;
    }

    public void Method()
    {
        var data = new RegisterFactoryData();
        _func.Invoke(data);
    }

}
