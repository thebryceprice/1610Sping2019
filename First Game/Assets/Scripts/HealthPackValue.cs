using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPackValue : MonoBehaviour
{
    public int healing;

    //other is what the healthpack is colliding with
    public void OnTriggerEnter(Collider other)
    {
        //if the variable "other" is has PlayerHealth...
        if (other.GetComponent<PlayerHealth>() != null)
        {
            //Calling Player health and then changing Player health variable
            other.GetComponent<PlayerHealth>().health += healing;
        }
        //Setting Healthpack object to be inactive
        gameObject.SetActive(false);
    }
}
