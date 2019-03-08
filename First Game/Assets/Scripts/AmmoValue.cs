using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoValue : MonoBehaviour
{
    public int ammo;

    public void ChangeAmmoAmount(int ammoAmount)
    {
        ammo += ammoAmount;
    }

    public void Display()
    {
        GetComponent<Text>().text = ammo.ToString();
    }
}