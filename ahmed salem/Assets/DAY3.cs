using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAY3 : MonoBehaviour
{
    string heroname = "ahmed";
    int heropower = 1000;

    string villainname = "mohamed";
    int villainpower = 900;

    float playerspeed = 20.1f;
    void setspeed (float speed)
    {
        playerspeed = speed;

    }
        
   
    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villainpower) 
        {
            print("hero is stronger");
        }
        else if (heropower == villainpower)
        {
            print("they have the same power");

        }
        else
        {
            print("villain is stronger");
        }

        print(playerspeed);

        setspeed(2.5f);

        print(playerspeed);

    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
