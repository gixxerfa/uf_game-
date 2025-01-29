using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class money : MonoBehaviour
{
    public TextMeshProUGUI moneyText;  // Reference to the TextMeshProUGUI component
    private int playerMoney = 1000;    // Example starting money


    // probably written by chatgpt
    private void Update()
    {
        moneyText.text = playerMoney.ToString();
    }

    // Example method to modify player's money
    public void AddMoney(int amount)
    {
        
        playerMoney += amount;
    }

    public void SubtractMoney(int amount)
    {   // temporary fixes :)
        playerMoney -= amount;
    }
}
