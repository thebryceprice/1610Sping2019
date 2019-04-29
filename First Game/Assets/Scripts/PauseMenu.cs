using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    //can be viewed by other scripts, BUT they can only check
    public static bool gamePaused = false;

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


    void Resume ()
    {
        //pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }


    void Pause ()
    {
        //PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
    
    
    
}


