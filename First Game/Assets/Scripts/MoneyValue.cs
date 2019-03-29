using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoneyValue : MonoBehaviour
{
    public int money;

    public void ChangeMoneyAmount(int moneyAmount)
    {
        money += moneyAmount;
    }

    public void Display()
    {
        GetComponent<Text>().text = money.ToString();
    }
}

//NEED TO DO
//    Decrease money value when shop is implemented