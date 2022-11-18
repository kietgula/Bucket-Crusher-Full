using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheSaw : MonoBehaviour
{
    [SerializeField] float rotationSpeed;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, rotationSpeed);
    }
}
