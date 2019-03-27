using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using Slider = UnityEngine.UI.Slider;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 150;
    public int currentHealth;

    void Awake()
    {
        currentHealth = startingHealth;
    }
}



//NEED TO DO
//    Sync and Update with "HealthBar" HUD display