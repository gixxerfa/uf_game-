using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tooltip : MonoBehaviour
{
    public string message;

    public void onmouseenter()
    {
        buttons_details_hover._instance.SetAndshowtooltip(message);
    }
    public void onmousexit() 
    {
    buttons_details_hover._instance.hidetooltip();
    
    }
}
