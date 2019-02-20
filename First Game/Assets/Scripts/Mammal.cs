using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Mammal : Animal
{
    public int FurCount = 10000;
    public float EatingSpeed = 0.4f;
    public bool CanEat = true;
    public UnityEvent Event;
        
    // Start is called before the first frame update
    void Start()
    {
        Event.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
