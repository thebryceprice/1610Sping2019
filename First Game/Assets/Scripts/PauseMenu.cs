using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //can be viewed by other scripts, BUT they can only check
    public static bool gamePaused = false;
    public GameObject pauseMenu;


    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    

    public void Resume ()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void Restart()
    {
        Application.LoadLevel("SampleScene");
        Time.timeScale = 1f;
        gamePaused = false;
        pauseMenu.SetActive(false);
    }


    public void Pause ()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
    
    
    
}


