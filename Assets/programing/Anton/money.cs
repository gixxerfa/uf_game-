using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class money : MonoBehaviour
{
    public TextMeshProUGUI moneyText;  // Reference to the TextMeshProUGUI component
    private int playerMoney = 1000;    // Example starting money



    private void Update()
    {
        moneyText.text = playerMoney.ToString();
    }

    // grab this for when the job function is being done and then asign the amount :)
    public void AddMoney(int amount)
    {
        
        playerMoney += 200;
    }
    // now grab these from another script and make them do different things depending on the button :)
    public void SubtractMoney(int amount)
    {   
        playerMoney -= amount;
    }
}
