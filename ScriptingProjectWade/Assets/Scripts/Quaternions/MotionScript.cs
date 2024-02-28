using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 6f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
    }
}
