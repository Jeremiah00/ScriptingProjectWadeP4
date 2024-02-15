using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass1 : MonoBehaviour
{
    // Start is called before the first frame update
    public FruitClass1()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    public virtual void Chop()
    {
        Debug.Log("The fruit has been chopped");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hell, I am a fruit.");
    }
}
