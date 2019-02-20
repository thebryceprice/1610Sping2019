using UnityEngine;
using UnityEngine.Events;

public class HelicopterEvent : MonoBehaviour
{
    public UnityEvent Event;

    private void OnCollisionEnter2D()
    {
        Event.Invoke();
        
    }
}