using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletEmitter;
    public float bulletMomentum;
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
            

            Rigidbody Temporary_Rigidbody;
            Temporary_Rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            Temporary_Rigidbody.AddForce(-transform.right * bulletMomentum);
            

            Destroy(Temporary_Bullet_Handler, 10.0f);
        }
    }
}
