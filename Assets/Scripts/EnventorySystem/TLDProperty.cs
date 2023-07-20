using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLDProperty : MonoBehaviour
{
    public BoolsForDeviceProperties BoolsValue;
    public ControllerInputsManualBounds ControllerInputBound;
    public TLDClass1 TLDDevice1;
    public TLDClass2 TLDDevice2;
    public DeviceType DeviceNumber;
    public GameObject ErrorScreen1, MainCanvas;

    public bool _ActivateDevice, PassedValueX, PassedValueA;

    public bool isSwitchOn;
    public enum TLDClass1
    {
        Working,
        Broken
    }

    public enum TLDClass2
    {
        Working,
        Broken
    }

    public enum DeviceType
    {
        Device1,
        Device2
    }
    public void Start()
    {
        MainCanvas.SetActive(false);
        if (DeviceNumber == DeviceType.Device1)
        {
            if (BoolsValue.tld1 == true)
            {
                TLDDevice1 = TLDClass1.Working;
            }
            else if (BoolsValue.tld1 == false)
            {
                TLDDevice1 = TLDClass1.Broken;
            }
        }

        if (DeviceNumber == DeviceType.Device2)
        {
            if (BoolsValue.tld2 == true)
            {
                TLDDevice2 = TLDClass2.Working;
            }
            else if (BoolsValue.tld2 == false)
            {
                TLDDevice2 = TLDClass2.Broken;
            }
        }
    }


    public void FixedUpdate()
    {
        
        PassedValueA = ControllerInputBound.A;
        PassedValueX = ControllerInputBound.X;

        if (DeviceNumber == DeviceType.Device1)
        {
            if (TLDDevice1 == TLDClass1.Broken)
            {
                ErrorScreen1.SetActive(true);
            }
            else
            {
                ErrorScreen1.SetActive(false);
            }
        }

        if (DeviceNumber == DeviceType.Device2)
        {
            if (TLDDevice2 == TLDClass2.Broken)
            {
                ErrorScreen1.SetActive(true);
            }
            else
            {
                ErrorScreen1.SetActive(false);
            }
        }
    }
    public void CanvasToActivate()
    {
        MainCanvas.SetActive(true);
    }

    public void CanvasToDeactivate()
    {
        MainCanvas.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;

        if (go.name == "hands:b_r_hand_ignore")
        {
            if (ControllerInputBound.A == true)
            {
                ToggleSwitch();
            }
            
        }



        if (go.name == "hands:b_l_hand_ignore")
        {

            if (ControllerInputBound.X == true)
            {
                ToggleSwitch();
            }
            
        }

    }


    public void ToggleSwitch()
    {
        isSwitchOn = !isSwitchOn;

        _ActivateDevice = isSwitchOn;

        if(isSwitchOn)
        {
            CanvasToActivate();
            isSwitchOn = true;
        }
        else
        {
            CanvasToDeactivate();
            isSwitchOn = false;
        }
    }
}
