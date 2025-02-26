using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class tooltip : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public string message;

    
public void OnPointerEnter(PointerEventData eventData)
    {
        
        buttons_details_hover._instance.SetAndshowtooltip(message);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        buttons_details_hover._instance.hidetooltip();
    }
}
   

