using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class tooltip : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    public string message;
    //public float ap_value = 1f;
    public Image buttonImage;
    

    void Start()
    {
        SetAlpha(0f);
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        
        buttons_details_hover._instance.SetAndshowtooltip(message);
        //GetComponent<Image>().enabled = true;
        SetAlpha(1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        buttons_details_hover._instance.hidetooltip();
        //GetComponent<Image>().enabled = false;
        SetAlpha(0f);
    }
    public void SetAlpha(float alpha)
    {
        Color color = buttonImage.color;
        color.a = alpha;
        buttonImage.color = color;
    }
    
}
   

