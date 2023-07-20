using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MobilePhone : MonoBehaviour
{
    public static MobilePhone Instance;
    public Material screenmaterial;
    public bool IstimerStart, Doorsunlocked, AudioDevice;
    public float timeValue = 40f;
    public AudioSource AudioSys;
    public ControllerInputsManualBounds ControllerInputBound;
    public bool _ActivateDevice, buttonA, buttonX,notepad,first,second;
    public GameObject PhoneText,doorunlocked;
    void Start()
    {
        AudioSys.mute = true;
        AudioDevice = false;
        screenmaterial.color = Color.black;
        IstimerStart = true;
        Doorsunlocked = false;
        Instance = this;
        AudioDevice = false;
        doorunlocked.SetActive(false);
    }
    void Update()
    {
        buttonA = OVRInput.Get(OVRInput.Button.One);
        buttonX = OVRInput.Get(OVRInput.Button.Three);

        if (IstimerStart == true)
        {
            if (timeValue > 0)
            {
                timeValue -= Time.deltaTime;
            }
            else
            {
                timeValue = 0;
                screenmaterial.color = Color.white;
                IstimerStart = false;
                Doorsunlocked = true;
                AudioDevice = true;
            }
        }
        PhonePickedup();

        if (first == true)
        {
            PhoneText.SetActive(true);
            if (OVRInput.Get(OVRInput.RawButton.X)|| OVRInput.Get(OVRInput.RawButton.A))
            {
                first = false;
            }
        }
        if (first == false)
        {
            PhoneText.SetActive(false);
        
        }

        if(Doorsunlocked== true)
        {
            doorunlocked.SetActive(true);
        }
    }
    public void PhonePickedup()
    {
        if(AudioDevice == true)
        {
            AudioSys.mute = false;
        }
        if (buttonA||buttonX)
        {
            AudioSys.mute = true;
            AudioDevice = false;
            
        //    notepad = true;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "hands:b_r_hand_ignore")
        {
            if (ControllerInputBound.A == true)
            {
                _ActivateDevice = true;
                Debug.Log("hello");
            //    PhoneText.SetActive(true);
            }
            else
            {
                _ActivateDevice = false;
            }
        }
        if (go.name == "hands:b_l_hand_ignore")
        {
            if (ControllerInputBound.X == true)
            {
                _ActivateDevice = true;
                Debug.Log("xbutton");
           //     PhoneText.SetActive(true);
            }
            else
            {
                _ActivateDevice = false;
            }
        }
        if (buttonA || buttonX)
        {
            buttonA = true;
            buttonX = true;
        }
        else
        {
            buttonA = false;
            buttonX = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        GameObject goo = other.gameObject;
        if (goo.name == "hands:b_r_hand_ignore")
        {
            if (ControllerInputBound.A == true)

            {
                _ActivateDevice = true;
                Debug.Log("hello");
       //         PhoneText.SetActive(true);
            }
            else
            {
                _ActivateDevice = false;
                PhoneText.SetActive(false);
            }
        }
        if (goo.name == "hands:b_l_hand_ignore")
        {
            if (ControllerInputBound.X == true)
            { 
            _ActivateDevice = true;
             Debug.Log("xbutton");
                   
            }
            else
            {
                _ActivateDevice = false;
                PhoneText.SetActive(false);

            }
    
     if (OVRInput.Get(OVRInput.RawButton.X)|| OVRInput.Get(OVRInput.RawButton.A))
            {
                first = true;
         PhoneText.SetActive(true);   

        }
            
        }//

        if (buttonA || buttonX)
        {
            buttonA = true;
            buttonX = true;
        }
        else
        {
            buttonA = false;
            buttonX = false;
        }
    }
 

    public void OnTriggerExit(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "hands:b_r_hand_ignore")
        {
            //MainCanvas.SetActive(false);
        }
        PhoneText.SetActive(false);
        if (go.name == "hands:b_l_hand_ignore")
        {
            //MainCanvas.SetActive(false);
        }
    }
}
