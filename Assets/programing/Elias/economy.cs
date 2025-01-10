using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

public class economy : MonoBehaviour
{
    public float money;
    public int dayactionnumber;
    public int trueDayactionnumber;
    public int inflationvalue;
    public int foodvalue, loancounter;
    public bool SL,ML,LL,SMS, LOANING;
    public float sl, ml, ll, sms;


    public void productcost()
    {
       //if( tag == ("_Carrot"))

        
            money = money - 160*inflationvalue;
        
    }
    public void inflation()
    {
        
            inflationvalue = Random.Range(1, 3);
        

    }
    private void Start()
    {
        loancounter = 3;
        inflationvalue = 1;
        money = 0;
    }
    

    public void small_loan()
    { 
        SL = true;   
      money = money + sl * inflationvalue;
        //money = money * -1.1f;
        // add to daycounter and make it dormant 
    }
    public void medium_loan()
    {
      ML = true;
        //money = money * -1.1f;
        // add to daycounter and make it dormant 

    }
    public void large_loan()
    {
        LL = true;
        //money = money * -1.1f;
        // add to daycounter and make it dormant 
    }
    public void sms_loan()
    {
        SMS = true; 
    }
    public void getmoney()
    {
        money = money+2000*inflationvalue;// add inflation number prob int        
        Debug.Log(money) ; 
    }
    private void Update()
    {
        if (LOANING == true)
        {
            //DIABLE LOAN BUTTONS :) (currently don't have the buttons in the scene)
            //SLbutton.enabled = false;
            //MLbutton.enabled = false;
            //LLbutton.enabled = false;
            //SMSbutton.enabled = false;
        }
        if (trueDayactionnumber == 3)
        {
            inflation();
        }
        if (loancounter == 0 && SL == true)
        {
            SL = false;
        }

    }
    public void Dayaction()
    {
        dayactionnumber += 1;

        if (dayactionnumber == 3)
        {
            trueDayactionnumber += 1;
            dayactionnumber = 0;    
        }
        if (trueDayactionnumber == 3)
        {
            
            
            if(SL == true)
            {
                money = money * 0.98f;
                loancounter = loancounter - 1;
            }
            if(loancounter == 0)
            {
                SL = false;
            }
            if (ML == true)
            {
                money = money * 0.95f;

            }
            if (loancounter == 0)
            {
                ML = false;
            }
            if (LL == true)
            {
                money = money * 0.92f;
            }
            if (loancounter == 0)
            {
                LL = false;
            }
            if (SMS == true)
            {
                money = money * 0.89f;
            }
            if (loancounter == 0)
            {
                SMS = false;
            }
            //switch to diffrent day for of main room!!!
            trueDayactionnumber = 0;    
        }

        

    }
    public void test()
    {
       
    }
    public void test_2()
    {

    }
    
}
