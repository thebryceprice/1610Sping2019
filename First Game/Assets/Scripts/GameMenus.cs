using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameMenus : MonoBehaviour
{
    public bool mouseClick;


    //When ESC game is clicked...bring up Pause Menu
    //Pause Menu Controls
    public void OnMouseDown()
    {
        if (mouseClick != true)
        {
            //Resume Game when Resume button is clicked
        }
        
        //Restart Game when Restart button is clicked
        if (mouseClick != true)
        {
            Application.LoadLevel("SampleScene");          
        }

        
        //End game (stop Unity) when Exit Game button is clicked
        if (mouseClick != true)
        {
            //End Game
        }
    }
}
