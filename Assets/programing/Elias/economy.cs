using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class economy : MonoBehaviour
{
    public float money=200;

    public void productcost()
    {
        if( tag == ("_Carrot"))
        {
            money = money - 31;
        }
    }
    public void infaltion()
    {
       //if(dayaction = 3)
        {
            float randomNumber = Random.Range(0, 4);
        }
    }
    public void loan()
    {

    }

}
