using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    private int experince;

    public int Experience
    {
        get
        {
            return experince;
        }
        set
        {
            experince = value;
        }
    }

    public int Level
    {
        get
        {
            return experince / 1000;
        }
        set
        {
            experince = value * 1000;
        }

    }

    public int Health { get; set; }
 
}
