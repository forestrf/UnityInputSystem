using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using System.Linq;
using System;
using UnityEngine.InputSystem.Controls;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class ControlsData
{
    public InputAction inputAction;
    public string inputActionString;

    // Constructor
    public ControlsData(ControlsInput controlsInput)
    {
        inputAction = controlsInput.m_Action;
        inputActionString = controlsInput.m_Action.ToString();
    }
}
