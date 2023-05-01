using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int intelligence = 5;
    void Start()
    {
        Greet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Greet()
    {
        switch(intelligence)
        {
            case 5:
                print("Why hello there good sir! Let me teach you about Trigonmetry");
                break;

            case 4:
                print("Hello and good day!");
                break;

            case 3:
                print("Whatya want");
                break;

            case 2:
                print("Grog SMASH");
                break;

            case 1:
                print("Ulg, glb, Pblblblbl");
                break;
            default:
                print("Incorrect intelligence level");
                break;
        }
    }
}
