using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletDamage : MonoBehaviour
{
    public int damage;

    //other is what the bullet is colliding with
    public void OnTriggerEnter(Collider other)
    {
        //if the variable "other" is has PlayerHealth...
        if (other.GetComponent<PlayerHealth>() != null)
        {
            //Calling Player health and then changing Player health variable
            other.GetComponent<PlayerHealth>().health -= damage;
        }

        
        //Setting Bullet object to be inactive
        gameObject.SetActive(false);
    }
}
