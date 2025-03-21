using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class day_mover : MonoBehaviour
{
    int daynumber, dayaction;
    public Image img;

    private void Update()
    {
        
    }
    void day_change()
    {
        if (daynumber == 54)
        {
            endgame("end_scene");
        }
        else if (dayaction != 3)
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
    }
    // improve
    void endgame(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
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
