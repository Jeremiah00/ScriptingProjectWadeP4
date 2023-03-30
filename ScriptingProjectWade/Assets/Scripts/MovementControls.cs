using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementControls : MonoBehaviour
{
    // Start is called before the first frame update]
    public float speed;
    public float turnSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical");
        float turnMovement = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }
}
