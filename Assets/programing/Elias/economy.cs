using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class economy : MonoBehaviour
{
    public float money;
    public int dayactionnumber;
    public int trueDayactionnumber;
    public int inflationvalue;


    public void productcost()
    {
       if( tag == ("_Carrot"))
        {
            money = money - 160*inflationvalue;
        }
    }
    public void infaltion()
    {
        if(trueDayactionnumber == 3)
        {
            inflationvalue = Random.Range(1, 3);
        }

    }
    private void Start()
    {
        money = 20000;
    }
    public void loan()
    {
        money = money * -1.1f;
    }
    public void getmoney()
    {

        money = money + 2000;//*inflationvalue;// add inflation number prob int 
        Debug.Log("moner");
    }
    public void Dayaction()
    {
        dayactionnumber += 1;
        
        if( dayactionnumber == 3 )
        {
            trueDayactionnumber += 1;
        }
        if( trueDayactionnumber == 3 )
        {
            //switch to diffrent day for of main room!!!
        }
        
    }
    

}
