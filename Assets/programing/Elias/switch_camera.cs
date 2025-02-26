using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class switch_camera : economy
{
    // values all of them
    public GameObject[] Cameralist = new GameObject[7];
    public GameObject[] Canvaslist = new GameObject[7];
    public int Manager;
    public GameObject doggy;
    public int food, stupidcameranumber;
    
    
    public void ChangeCamera() // the animation for when the camera changes that is for now broken due to unity stuff
    {
        GetComponent<Animator>().SetTrigger("Change");
    }

    
    public void cc(int Camera)// isak cool better than me camera code 
    {
        for (int i = 0; i < Cameralist.Length; i++) { 
            Cameralist[i].gameObject.SetActive(false);
        }
        
        for (int i = 0; i < Canvaslist.Length; i++)
        {
            Canvaslist[i].gameObject.SetActive(false);
        }
        Cameralist[Camera].SetActive(true);
        Canvaslist[Camera].SetActive(true);

    }

public void Start() // value specifiks 
    {
        food = 10;
        stupidcameranumber = 0;
        cc(0);
    }
    private void Update()
    {
        if (food == 0)// hospital cam 
        {
            cc(4);
        }
        if (stupidcameranumber > 1)//test for stuff i thnk day change 
        {
            Debug.Log("camera_dog");
            //Cam_6();
        }
        
        if (trueDayactionnumber == 3)
        {
            
            if(stupidcameranumber == 0)
            {
                print("cam5");
                //Cam_5();
            }
            stupidcameranumber = +1;
        }
        if (money < 0) // bankrupt end
        {
            cc(8);
        }
    }

    // all of the bad and old way to controll the camera.
    // gone :(

    // more test functions with stuff idon't remember in them 
    public void dog()
    {
        cc(1);

        //Camera1.transform.position =doggy.transform.position;
        //GetComponent<Animator>().SetTrigger("Change");
    }
    public void dog_2()
    {
        cc(3);

        //Camera1.transform.position =doggy.transform.position;
        //GetComponent<Animator>().SetTrigger("Change");
    }
    public void dag_uppies(int day_number_uppies) 
    {
        if (dayactionnumber == 3)
        {
            trueDayactionnumber += 1;
            dayactionnumber = day_number_uppies;

        }
        // NOT WORK ______________________________________________________
        else
        {
            dayactionnumber += day_number_uppies;
        }

    }
}
