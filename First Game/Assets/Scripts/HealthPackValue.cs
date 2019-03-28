using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPackValue : MonoBehaviour
{
    public int health;

    public void ChangeHealthAmount(int healthAmount)
    {
        health += healthAmount;
    }
}

//NEED TO DO
//    Figure out how to add function under "Player" object that ties Health Pack Event to PlayerHealth
//    On pickup, update "PlayerHealth" +20 Health