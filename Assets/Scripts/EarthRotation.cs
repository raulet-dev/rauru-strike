﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRotation : MonoBehaviour
{
    float rotY;
    public Vector3 angle;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
    
    transform.Rotate(angle* Time.deltaTime); 
        
    }
}
