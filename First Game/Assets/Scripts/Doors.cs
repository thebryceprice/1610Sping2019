using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class Doors : MonoBehaviour
{

    public int levelToLoad;
    private GameMenus _gm;

    
    void Start()
    {
        _gm = GameObject.FindGameObjectWithTag("GameMenus").GetComponent<GameMenus>();
    }


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

    
    
    
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ammo Pick Up"))
        {
            _gm.InputText.text = ("");
        }
    }
}
