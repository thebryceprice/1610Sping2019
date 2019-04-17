using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    //tell where bullet is shooting from
    public GameObject bulletEmitter;
    //instance
    public GameObject bullet;
    //forward push on instance
    public float bulletMomentum;

    private void Start()
    {
        throw new System.NotImplementedException();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //bullet instantiation
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;
            
            //correction of incorrectly rotated bullets
            //Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);


            //call the rigidbody of created bullets
            Rigidbody Temporary_Rigidbody;
            Temporary_Rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            
            
            
            
            //bullets are being pushed by the amount set
            Temporary_Rigidbody.AddForce(transform.right * bulletMomentum);
            
            
            
            
            //destruction of bullets after 10 seconds
            Destroy(Temporary_Bullet_Handler, 10.0f);





        }
    }
}
