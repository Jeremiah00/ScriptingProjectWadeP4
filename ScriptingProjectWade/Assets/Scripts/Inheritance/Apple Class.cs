using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleClass : FruitClass
{
    // Start is called before the first frame update
    public AppleClass()
    {
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    public AppleClass(string newColor) : base(newColor)
    {
        Debug.Log("2nd Apple Constructor Called");
    }
}
