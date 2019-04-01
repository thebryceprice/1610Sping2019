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
    public Slider healthSlider;

    private void Start()
    {
        health = 100;
    }

    public void Update()
    {
        healthSlider.value = health;
    }
}