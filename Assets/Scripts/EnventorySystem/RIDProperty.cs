using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RIDProperty : MonoBehaviour
{
    public BoolsForDeviceProperties BoolsValue;
    public ControllerInputsManualBounds ControllerInputBound;
    public RIDClass1 RIDDevice1;
    public RIDClass2 RIDDevice2;
    public DeviceType DeviceNumber;
    public GameObject ErrorScreen1, MainCanvas;
    public bool _ActivateDevice, isSwitchOn;
    public enum RIDClass1
    {
        Working,
        Broken
    }

    public enum RIDClass2
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
            if (BoolsValue.rid1 == true)
            {
                RIDDevice1 = RIDClass1.Working;
            }
            else if (BoolsValue.rid1 == false)
            {
                RIDDevice1 = RIDClass1.Broken;
            }
        }
        
        if(DeviceNumber == DeviceType.Device2)
        {
            if (BoolsValue.rid2 == true)
            {
                RIDDevice2 = RIDClass2.Working;
            }
            else if (BoolsValue.rid2 == false)
            {
                RIDDevice2 = RIDClass2.Broken;
            }
        }
        
    }

    public void FixedUpdate()
    {
        if (DeviceNumber == DeviceType.Device1)
        {
            if (RIDDevice1 == RIDClass1.Broken)
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
            if (RIDDevice2 == RIDClass2.Broken)
            {
                ErrorScreen1.SetActive(true);
            }
            else
            {
                ErrorScreen1.SetActive(false);
            }
        }

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

        if (isSwitchOn)
        {
            MainCanvas.SetActive(true);
            isSwitchOn = true;
        }
        else
        {
            MainCanvas.SetActive(false);
            isSwitchOn = false;
        }
    }



}
