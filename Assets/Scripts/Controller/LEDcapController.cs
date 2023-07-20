using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEDcapController : MonoBehaviour
{
    public Animator anim;
    public bool _IsOpen, isSwitchOn, _ActivateDevice;
    public float timeRemaining;
    public ControllerInputsManualBounds TriggersFloat;
    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if(go.name == "hands:b_l_hand_ignore" ||  go.name == "hands:b_r_hand_ignore")
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else

            {
                timeRemaining = 2;
            }

            if(timeRemaining <= 0.5)
            {
                if(TriggersFloat.leftFloat >= 0.3f || TriggersFloat.rightFloat >= 0.3f)
                {
                    ToggleSwitch();
                }
            }
            
        }

    }


    public void ToggleSwitch()
    {
        isSwitchOn = !isSwitchOn;

        _ActivateDevice = isSwitchOn;

        if (isSwitchOn)
        {
            anim.SetBool("Open", true);
            isSwitchOn = true;
        }
        else
        {
            anim.SetBool("Open", false);
            isSwitchOn = false;
        }
    }
}
