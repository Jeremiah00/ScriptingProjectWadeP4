using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    int myInt = 5;
    void Start()
    {
        Debug.Log(TimesTwo(myInt));
    }

    int TimesTwo(int num)
    {
        int result;
        result = num * 2;
        return result;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
