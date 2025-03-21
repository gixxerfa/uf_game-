using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class stats_manager : MonoBehaviour
{
    public Image img;
    int current_food;
    int max_food = 4;
    public Sprite  h4,h3,h2,h1;

    private void Start()
    {
        current_food = max_food;

    }
    private void Update()
    {
        food_changer();
        // functioning food display i think food just does nothing :)
        if (current_food == 4)
            {
            img.sprite = h4;
            }
        else if (current_food == 3) 
            {
                img.sprite=h3;
            }
        else if (current_food == 2)
            {
                img.sprite =h2;
            }
        else if (current_food == 1)
            {
                img.sprite = h1;
            }

    }


   public void food_changer()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            current_food -= 1;
        }
    }


}
