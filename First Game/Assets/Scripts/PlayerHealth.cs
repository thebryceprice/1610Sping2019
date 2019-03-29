using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;
using Slider = UnityEngine.UI.Slider;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int currentHealth;
    //public Slider healthBar;

    private void Awake()
    {
        currentHealth = 100;
    }
}


//NEED TO DO
//    Sync and Update with "HealthBar" HUD display