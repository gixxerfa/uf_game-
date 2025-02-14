using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.UI;

public class economy : MonoBehaviour
{
    // all of the values :)
    public float money;
    public int dayactionnumber;
    public int trueDayactionnumber;
    public int inflationvalue;
    public int foodvalue = 10, loancounter;
    public bool SL,ML,LL,SMS, LOANING;
    public float sl, ml, ll, sms;


    // all of the diffrent food options 
    public void smallcost() // small
    {
            money = money - 160*inflationvalue;
        foodvalue = foodvalue + 3;
    }
    public void mediumcost() // medium 
    {
        money = money - 200 * inflationvalue;
        foodvalue = foodvalue + 5;
    }
    public void bigcost() // big 
    {
        money = money - 250 * inflationvalue;
        foodvalue = foodvalue + 10;
    }
    public void inflation() // more or less the range och magnitude that the infaltion can be 
    {
        
            inflationvalue = Random.Range(1, 3);
        

    }
    private void Start() //specifing values att the start of the game + some test values 
    {
        loancounter = 3;
        inflationvalue = 1;
        money = 0;
        foodvalue = foodvalue -5 ;
    }
    
    // all of the potions of loans more or less but mostly just for for the bool to work to make the loans work
    public void small_loan() // small 
    { 
        SL = true;   
      money = money + sl * inflationvalue;
        //old //money = money * -1.1f;
        //old  // add to daycounter and make it dormant 
    }
    public void medium_loan() //medium 
    {
      ML = true;
        //old //money = money * -1.1f;
        //old // add to daycounter and make it dormant 

    }
    public void large_loan() //big
    {
        LL = true;
        //old //money = money * -1.1f;
        //old // add to daycounter and make it dormant 
    }
    public void sms_loan()// sms
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
        if (LOANING == true) // currently not working because no buttons to use on yet but it's to make the loan buttons go grey when clicked and stop working
        {
            //DIABLE LOAN BUTTONS :) (currently don't have the buttons in the scene)
            //SLbutton.enabled = false;
            //MLbutton.enabled = false;
            //LLbutton.enabled = false;
            //SMSbutton.enabled = false;
        }
        if (trueDayactionnumber == 3) // more or less to make infaltion change each month 
        {
            inflation();
        }
        if (loancounter == 0 && SL == true)// to check if loan is gone and the loand bool is true to make sure you haven't just not taken a loan :)
        {
            SL = false;
        }
        if (loancounter == 0 && ML == true)// to check if loan is gone and the loand bool is true to make sure you haven't just not taken a loan :)
        {
            ML = false;
        }
        if (loancounter == 0 && LL == true)// to check if loan is gone and the loand bool is true to make sure you haven't just not taken a loan :)
        {
            LL = false;
        }
        if(loancounter == 0 && SMS == true)// to check if loan is gone and the loand bool is true to make sure you haven't just not taken a loan :)
        {  
            SMS = false; 
        }


        if(trueDayactionnumber == 1) // work in progress but mostly will be camera changes 
        {
            //old// make main room/ if have time all rooms first variation based on time.

        }
        if (trueDayactionnumber == 2)// work in progress but mostly will be camera changes 
        {
            //old// make main room/ if have time all rooms 2 variation based on time.
        }
        if (trueDayactionnumber == 3)// work in progress but mostly will be camera changes 
        {
            //old// make main room/ if have time all rooms third variation based on time.
        }

       
    }
    public void Dayaction()// whole of the diffrent time stuff like days moths and time calculations in the game. mind you it's not accuret to real life.
    {
        dayactionnumber += 1;

        if (dayactionnumber == 3) // make you hungry each cyckle of day 
        {
            trueDayactionnumber += 1;
            dayactionnumber = 0;
            foodvalue = foodvalue - 4;
        }
        if (trueDayactionnumber == 3)
        {
            
            // all of the real loans in other words the intrest deduction.
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
    // my two test voids to test buttons with code i don't want or is to changed to be put into the live code.
    public void test()
    {
       
    }
    public void test_2()
    {

    }
    
}
