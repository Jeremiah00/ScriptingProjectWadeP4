using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstantiate;
            rocketInstantiate = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation);
            rocketInstantiate.AddForce(barrelEnd.up * 500);
        }
    }
}
