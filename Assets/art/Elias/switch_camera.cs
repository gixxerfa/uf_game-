using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class switch_camera : economy
{
    // values all of them
    public GameObject[] Cameralist = new GameObject[7];
    public GameObject Camera1, Camera2, Camera3, Camera4, Camera5, Camera6, Camera7, Camera8; 
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
        Cameralist[Camera].SetActive(true);

    }

public void Start() // value specifiks 
    {
        food = 10;
        stupidcameranumber = 0;
        cc(2);
    }
    public void Update()
    {
        if (food == 0)// hospital cam 
        {
            Cam_4();
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
            Cam_8();
        }
    }

    // all of the bad and old way to controll the camera.
    public void Cam_1()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
    }
    public void Cam_2()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
    }
   public void Cam_3()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(true);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
    }
    public void Cam_4()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(true);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
    }
    public void Cam_5()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(true);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
    }
    public void Cam_6()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(true);
        Camera7.SetActive(false);
        Camera8.SetActive(false);
    }
    public void Cam_7()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(true);
        Camera8.SetActive(false);
    }
    public void Cam_8()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        Camera8.SetActive(true);
    }

    // more test functions with stuff idon't remember in them 
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
