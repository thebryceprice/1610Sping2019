﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DONTDESTORYONLOAD : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
