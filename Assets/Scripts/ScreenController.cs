using System;
using System.Collections;
using System.Collections.Generic;    
using UnityEngine;
using UnityEngine.Serialization;

public class ScreenController : MonoBehaviour
{
    public static ScreenController Instance;
    

    private void Awake()
    {
        Instance = this;
    }
    
    
}
