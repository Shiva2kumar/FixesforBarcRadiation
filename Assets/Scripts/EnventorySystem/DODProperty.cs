using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DODProperty : MonoBehaviour
{
    public BoolsForDeviceProperties BoolsValue;
    public ControllerInputsManualBounds ControllerInputBound;
    public DODClass1 DODDevice1;
    public DODClass2 DODDevice2;
    public DeviceType DeviceNumber;
    public GameObject ErrorScreen1, MainCanvas;
    public bool _ActivateDevice, isSwitchOn;
    public enum DODClass1
    {
        Working,
        Broken
    }

    public enum DODClass2
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
            if (BoolsValue.DOD == true)
            {
                DODDevice1 = DODClass1.Working;
            }
            else if (BoolsValue.DOD == false)
            {
                DODDevice1 = DODClass1.Broken;
            }
        }

        if (DeviceNumber == DeviceType.Device2)
        {
            if (BoolsValue.DOD1 == true)
            {
                DODDevice2 = DODClass2.Working;
            }
            else if (BoolsValue.DOD1 == false)
            {
                DODDevice2 = DODClass2.Broken;
            }
        }
    }


    public void FixedUpdate()
    {
        if (DeviceNumber == DeviceType.Device1)
        {
            if (DODDevice1 == DODClass1.Broken)
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
            if (DODDevice2 == DODClass2.Broken)
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
