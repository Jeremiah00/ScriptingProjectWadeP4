using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float coffeeTemperture = 85.0f;
    float hotLimitTemperture = 70.0f;
    float coldLimitTemperture = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TempertureTest();

        coffeeTemperture -= Time.deltaTime * 5f;

        if (Input.GetKeyDown(KeyCode.R))
        {
            coffeeTemperture = 85.0f;
        }
        

        void TempertureTest()
        {
            if (coffeeTemperture > hotLimitTemperture)
            {
                print("Coffee is to hot");

            }   
            else if ( coffeeTemperture < coldLimitTemperture)
            {
                print("Coffee is too cold");

            }
            else
            {
                print("Coffe is just right");
            }
        }

    }
}

