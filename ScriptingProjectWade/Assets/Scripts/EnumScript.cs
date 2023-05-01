using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    // Start is called before the first frame update
    enum Direction {North, East, West, South};
    
    void Start()
    {
        Direction myDirection;

        myDirection = Direction.North;
        Debug.Log("Normal Direction: " + myDirection);
        Debug.Log("Reversed Direction: " + ReverseDirection(myDirection));
        
    }

    Direction ReverseDirection (Direction dir)
    {
        if(dir == Direction.North)
        {
            dir = Direction.South;
        }
        else if (dir == Direction.South)
        {
            dir = Direction.North;
        }
        else if (dir == Direction.East)
        {
            dir = Direction.West;
        }
        else if (dir == Direction.West)
        {
            dir = Direction.East;
        }
        return dir;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
