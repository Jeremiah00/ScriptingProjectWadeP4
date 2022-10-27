using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorComponent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.cyan;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Renderer>().material.color = Color.gray;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
        while (Input.GetKeyDown(KeyCode.W))
        {
            Vector2 position = transform.position;
            position.x = position.x + 0.1f;
            transform.position = position;
        }
    }
}
