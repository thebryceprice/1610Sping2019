using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using Slider = UnityEngine.UI.Slider;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthBar;

    void Start()
    {
        currentHealth = startingHealth;
    }
    
    public void Display()
    {
        healthBar.value = currentHealth;
    }
}


//NEED TO DO
//    Sync and Update with "HealthBar" HUD display