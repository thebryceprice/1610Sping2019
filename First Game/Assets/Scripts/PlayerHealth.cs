using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;
using Slider = UnityEngine.UI.Slider;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int health;
    public Slider healthSlider;
    private Scene scene;

    public void Start()
    {
        health = 100;
        scene = SceneManager.GetActiveScene();
    }
    
    
//Display and Death System
    public void Update()
    {
        healthSlider.value = health;
        //if health value reaches 0...
        if (health <= 0)
        {
            //reload the scene
            
            Application.LoadLevel("SampleScene");
            Destroy(gameObject);
        }
    }
}