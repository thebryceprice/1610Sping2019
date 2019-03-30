using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.UIElements;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    public UnityEvent OnGrounded, OffGrounded;

    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float Speed = 3;

    private CharacterController controller;
    private Vector3 position;
    private Vector3 scale;


    void Start()
    {
        controller = GetComponent<CharacterController>();
        scale = transform.localScale;
    }

    void Update()
    {
/*        if (controller.isGrounded)
        {
            OnGrounded.Invoke();
        }
        else
        {
            OffGrounded.Invoke();
        }*/

        //position.y = Input.GetAxis("Vertical")*Speed*Time.deltaTime;
        position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        
        //if "a" key is pressed, character moves left and x scale is negative
        //if "d" key is pressed, character moves right and x scale is positive

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localScale = new Vector3(-scale.x, scale.y, scale.z);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = new Vector3(scale.x, scale.y, scale.z);
        }
        
        if (controller.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            position.y = jumpSpeed;
        }

        position.y -= gravity * Time.deltaTime;
        controller.Move(position * Time.deltaTime);



        //controller.Move(position);
    }
}