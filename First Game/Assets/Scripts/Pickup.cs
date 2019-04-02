using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{
    public UnityEvent ammoEvent;
    public UnityEvent moneyEvent;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ammo Pick Up"))
        {
            other.gameObject.SetActive(false);
            ammoEvent.Invoke();
        }

        if (other.gameObject.CompareTag("Money Pick Up"))
        {
            other.gameObject.SetActive(false);
            moneyEvent.Invoke();
        }
    }
}
