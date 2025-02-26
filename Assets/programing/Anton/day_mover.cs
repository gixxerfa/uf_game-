using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day_mover : MonoBehaviour
{
    int daynumber, dayaction;
    // improve
    void day_change()
    {
        if (daynumber != 3)
        {   dayaction += 1;
            print(dayaction);
            print(daynumber);
        }
        else if (dayaction == 3)
        {   dayaction = 0;
            daynumber += 1;
            print(dayaction);
            print(daynumber);
        }
        else if (daynumber == 54)
        {   
            endgame();
        }
    }
    // improve
    void endgame()
    {
        // make a way to end the game
    }

    //improve
    void event_managment(int event_type)
    {
        if (event_type == 1)
        {
            // make events happen
        }
        else
        {
            // events that can occur at the end of the day
        }
    }

}
