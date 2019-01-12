﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicInput : IInputInterface{
    public float GetHorizontal()
    {
        return Input.GetAxis("Horizontal");
    }

    public bool GetJump()
    {
        return Input.GetAxis("Jump") != 0;
    }

    public float GetVertical()
    {
        return Input.GetAxis("Vertical");
    }  
}