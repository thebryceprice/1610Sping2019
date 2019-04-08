using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructibles : MonoBehaviour
{
    //When Bullets collide with an object tagged "Destructible
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            //Play Destructible's animation when bullet collides
            
        }
    }
}
