using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public GameObject bulletEmitter;
    public GameObject bullet;
    public float bulletMomentum;
    public MoveCharacter moveCharacter;

    private void Start()
    {
        moveCharacter = transform.parent.GetComponent<MoveCharacter>();
        
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //bullet instantiation
            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(bullet, bulletEmitter.transform.position, bulletEmitter.transform.rotation) as GameObject;


            //call the rigidbody of created bullets
            Rigidbody Temporary_Rigidbody;
            Temporary_Rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();
            
            
            //bullets are being pushed by the amount set
            if (moveCharacter.facingRight)
            {
                Temporary_Rigidbody.AddForce(transform.right * bulletMomentum);
            }
            else
            {
                Temporary_Rigidbody.AddForce(-transform.right * bulletMomentum);
            }
            
            
            //Reduce AmmoValue by 1 every click, do not shoot when Ammovalue is value = 0
            
            
            
            //destruction of bullets after 10 seconds
            Destroy(Temporary_Bullet_Handler, 10.0f);
        }
    }
}
