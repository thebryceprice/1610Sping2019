using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class BulletDamage : MonoBehaviour
{
    public int damage;
    public UnityEvent healthEvent;
    
    public void ChangeCurrentHealthAmount(int currentHealthAmount)
    {
        damage -= currentHealthAmount;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            //GetComponent<PlayerHealth>().currentHealth = damage.ToString();
            healthEvent.Invoke();
        }
    }
}




//NEED TO DO
//    "Bullet" box-colliders remove -20 Health from "PlayerHealth"
