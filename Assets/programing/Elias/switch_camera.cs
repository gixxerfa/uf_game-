using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class switch_camera : economy
{
    //public GameObject[] Camera1 = new GameObject[8];
    public GameObject Camera1, Camera2, Camera3, Camera4, Camera5, Camera6;
    
    public int Manager;
    public GameObject doggy;
    public int food, stupidcameranumber;
    
    
    public void ChangeCamera()
    {
        GetComponent<Animator>().SetTrigger("Change");
    }
    
    
    public void ManageCamera()
    {
        if (Manager == 0)
        {
            Cam_2();
            Manager = 1;
        }
        else
        {
            Cam_1();
            Manager = 0;
        }
    }
    public void Start()
    {
        food = 10;
        stupidcameranumber = 0;
    }
    public void Update()
    {
        if (food == 0)
        {
            Cam_4();
        }
        if (stupidcameranumber > 1)
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
    }


    public void Cam_1()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
    public void Cam_2()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
   public void Cam_3()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(true);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
    public void Cam_4()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(true);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
    public void Cam_5()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(true);
        Camera6.SetActive(false);
    }
    public void Cam_6()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(true);
    }

    public void dog()
    {
        

        //Camera1.transform.position =doggy.transform.position;
        //GetComponent<Animator>().SetTrigger("Change");
    }
    public void dog_2()
    {
        //if (trueDayactionnumber == 3)
        {

            if (stupidcameranumber == 0)
            {
                print("cam5");
                //Cam_5();
            }
            stupidcameranumber = stupidcameranumber +1;
        }
    }
}
