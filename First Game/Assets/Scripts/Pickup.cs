﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pickup : MonoBehaviour
{
    public UnityEvent ammoEvent;
    public UnityEvent healthPackEvent;
    public UnityEvent bulletEvent;
    
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
            healthPackEvent.Invoke();
        }

        if (other.gameObject.CompareTag("Bullet"))
        {
            other.gameObject.SetActive(false);
            bulletEvent.Invoke();
        }
    }
}
