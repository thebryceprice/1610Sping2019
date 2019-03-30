using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;
using Slider = UnityEngine.UI.Slider;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    private void Start()
    {
        health = 100;
    }

        

 //Showing Current Health on Health Bar Slider
    //private void Update()
    //{
    //    GetComponent<Slider>(healthBar).value = health;
    //}
}