using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;
using Object = System.Object;

public class Doors : MonoBehaviour
{

    public int levelToLoad;
    private GameMenus _gm;

    
    void Start()
    {
        _gm = GameObject.FindGameObjectWithTag("GameMenus").GetComponent<GameMenus>();
    }

    //when "e" is pressed while player is colliding with the door, load specified scene
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
                _gm.InputText.text = ("Press [E] to Enter");
                if (Input.GetKeyDown("e"))
                {
                    SceneManager.LoadScene(levelToLoad);
                }
        }
    }

    
    
    
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown("e"))
            {
                SceneManager.LoadScene(levelToLoad);
            }
        }
    }
}
