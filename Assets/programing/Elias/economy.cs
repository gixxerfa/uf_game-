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
        if (loancounter == 0 && ML == true)
        {
            ML = false;
        }
        if (loancounter == 0 && LL == true)
        {
            LL = false;
        }
        if(loancounter == 0 && SMS == true)
        {  
            SMS = false; 
        }


        if(trueDayactionnumber == 1)
        {
            // make main room/ if have time all rooms first variation based on time.

        }
        if (trueDayactionnumber == 2)
        {
            // make main room/ if have time all rooms 2 variation based on time.
        }
        if (trueDayactionnumber == 3)
        {
            // make main room/ if have time all rooms third variation based on time.
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
            
            if (ML == true)
            {
                money = money * 0.95f;

            }
            
            if (LL == true)
            {
                money = money * 0.92f;
            }
           
            if (SMS == true)
            {
                money = money * 0.89f;
            }
           
            //switch to diffrent day for of main room!!!
            trueDayactionnumber = 1;    
        }

        

    }
    public void test()
    {
       
    }
    public void test_2()
    {

    }
    
}
