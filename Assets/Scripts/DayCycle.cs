﻿using UnityEngine;
using System.Collections;

public class DayCycle : MonoBehaviour {

    public float rate;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * rate, 0, 0);
    }
}
