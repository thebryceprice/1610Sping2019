using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Conditionals : MonoBehaviour
{
    public UnityEvent OnEvent, OffEvent;

    public bool OnBool;

    public int Number = 11;

    public string Password;

    private void Update()
{
        if(OnBool){}
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
