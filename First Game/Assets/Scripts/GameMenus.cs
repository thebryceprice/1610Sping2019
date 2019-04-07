using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenus : MonoBehaviour
{
    public bool mouseClick;
    public Text InputText;


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
            SceneManager.LoadScene("SampleScene");          
        }

        
        //End game (stop Unity) when Exit Game button is clicked
        if (mouseClick != true)
        {
            //End Game
        }
    }
}
