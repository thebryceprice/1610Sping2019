using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    
    //Bar Doors
    private void OnCollisionEnter(Collision other)
    {
        //if Player collides with the Bar Doors...allow ButtonPress(W) to transform player in between doors
        if (other.gameObject.CompareTag("Player"))
                {
                    //transform player to 
                }
    }
}
