using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : Animal
{
    public Color WingColor;
    
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = SkinColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
