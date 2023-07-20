using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputIntractions : MonoBehaviour
{
    public float TriggerL,TriggerR;
    public bool ButtonX,ButtonA, ButtonB, ButtonY;
    public ControllerInputsManualBounds Inputs;
    public void Update()
    {
        TriggerL = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
        TriggerR = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);

        ButtonA = OVRInput.Get(OVRInput.Button.One);
        ButtonX = OVRInput.Get(OVRInput.Button.Three);

        ButtonB = OVRInput.Get(OVRInput.Button.Two);
        ButtonY = OVRInput.Get(OVRInput.Button.Four);
        Inputs.leftFloat = TriggerL;
        Inputs.rightFloat = TriggerR;
        Inputs.A = ButtonA;
        Inputs.X = ButtonX;
        Inputs.B = ButtonB;
        Inputs.Y = ButtonY;
    }

    public void OnDisable()
    {

        Inputs.leftFloat = 0f;
        Inputs.rightFloat = 0f;

        Inputs.A = false;
        Inputs.X = false;
        Inputs.B = false;
        Inputs.Y = false;

    }
}
