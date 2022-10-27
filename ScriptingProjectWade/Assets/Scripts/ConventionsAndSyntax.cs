using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConventionsAndSyntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Tells me the x position of the game object
        Debug.Log($"X position is: {transform.position.x}");

        if (transform.position.y <= 5f)
        {
            Debug.Log("I'm about to start throwing hands");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
