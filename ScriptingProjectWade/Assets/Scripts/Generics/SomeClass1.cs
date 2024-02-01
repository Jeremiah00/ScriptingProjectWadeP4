using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass1 : MonoBehaviour
{
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
