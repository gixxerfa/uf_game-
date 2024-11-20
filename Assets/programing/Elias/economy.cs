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
    public int foodvalue;


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
        inflationvalue = 1;
        money = 0;
    }
    
    public void small_loan()
    {
        money = money + 4000*inflationvalue;
        //money = money * -1.1f;
        // add to daycounter and make it dormant 
    }
    public void medium_loan()
    {

        //money = money * -1.1f;
        // add to daycounter and make it dormant 

    }
    public void large_loan()
    {

        //money = money * -1.1f;
        // add to daycounter and make it dormant 
    }
    public void sms_loan()
    {

    }
    public void getmoney()
    {

        money = money+2000*inflationvalue;// add inflation number prob int 
        
        Debug.Log(money) ; 
    }
    private void Update()
    {

        if (trueDayactionnumber == 3)
        {
            inflation();
        }

    }
    public void Dayaction()
    {
        dayactionnumber += 1;

        if (dayactionnumber == 3)
        {
            trueDayactionnumber += 1;
        }
        if (trueDayactionnumber == 3)
        {
            small_loan();
            medium_loan();
            large_loan();
            sms_loan(); 
            //switch to diffrent day for of main room!!!
        }



    }
    public void hospital()
    {
        if(foodvalue==0)
        {
            //add camera switch to hosptial scene!!!!!
        }
    }
}
