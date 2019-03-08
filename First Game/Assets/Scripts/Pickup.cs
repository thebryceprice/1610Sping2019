using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{
    public UnityEvent ammoEvent;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ammo Pick Up"))
        {
            other.gameObject.SetActive(false);
            ammoEvent.Invoke();
        }

        if (other.gameObject.CompareTag("Health Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
