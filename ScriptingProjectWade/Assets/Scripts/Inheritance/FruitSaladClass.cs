using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass : MonoBehaviour
{
    void Start()
    {
        
        Debug.Log("Creating the FruitClass");
        FruitClass myFruitClass = new FruitClass();
        Debug.Log("Creating the AppleClass");
        AppleClass myAppleClass = new AppleClass();


        myFruitClass.SayHello();
        myFruitClass.Chop();


        myAppleClass.SayHello();
        myAppleClass.Chop();

     
        Debug.Log("Creating the FruitClass");
        myFruitClass = new FruitClass("yellow");
        Debug.Log("Creating the AppleClass");
        myAppleClass = new AppleClass("green");

        
        myFruitClass.SayHello();
        myFruitClass.Chop();

      
        myAppleClass.SayHello();
        myAppleClass.Chop();
    }
}
