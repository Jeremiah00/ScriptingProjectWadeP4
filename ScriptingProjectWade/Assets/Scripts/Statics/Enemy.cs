using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public static int enemyCount = 0;

    public Enemy()
    {
        enemyCount++;
    }
}
