using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw3 : MonoBehaviour
{
    //hero 
    string hero_n = ("mohamed");
    int hero_p = 10;

    //vall
    string vall_n = ("venom");
    int vall_p = 8;

    //
    int playerspeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        if (hero_p > vall_p)
        {
            print("hero win");
        }
        else if (hero_p < vall_p)
        {
            print("venom win");

        }

        setspeed(2.5f);
        CompareSpeed();
    }

    void setspeed(float playerspeed2)
    {
        print("old player speed is" + playerspeed);
        playerspeed2 =2.5f;
        print("new player speed is " + playerspeed2);
    }
    void CompareSpeed()
    {
     if(10 > 2.5)
        {
            print("10 is biger");
        }
     else if(10 < 2.5)
        {
            print("2.5 is biger");
        }
     else
        {
            print("the will be equal");
        }
    }
}
