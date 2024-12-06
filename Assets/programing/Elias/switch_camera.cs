using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switch_camera : MonoBehaviour
{
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;
    public GameObject Camera7;
    public GameObject Camera8;
    public int Manager;
    public GameObject doggy;

    
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
   
    private void Update()
    {
        //if(Input.GetMouseButton(0))
        {
            dog();
        }
    }


    public void Cam_1()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
    }
    public void Cam_2()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        Camera3.SetActive(false);
    }
   public void Cam_3()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(true);
    }
    public void dog()
    {
        //Camera1.transform.position =doggy.transform.position;
        //GetComponent<Animator>().SetTrigger("Change");
    }
}
