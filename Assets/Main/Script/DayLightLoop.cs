﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayLightLoop : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * speed);
    }
}
