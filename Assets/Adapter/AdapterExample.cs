using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdapterExample : IAdapterExample
{
    public string Example()
    {
        return AdaptedClass.nameExample;
    }
}
