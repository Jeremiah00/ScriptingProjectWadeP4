using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateANdFixedUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void FixedUpdate()
    {
        Debug.Log("FixedUpate Time: " + Time.deltaTime);

    }
    void Update()
    {
        Debug.Log("Update time: " + Time.deltaTime);
    }
}
