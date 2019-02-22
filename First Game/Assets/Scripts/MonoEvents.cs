using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent StartEvent, EnableEvent, MouseDownEvent
        , UpdateEvent;
    
    void Start()
    {
        StartEvent.Invoke();
        
    }
    
    private void OnEnable()
    {
        
    }
    
    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }

    void Update()
    {
        
    }
}
