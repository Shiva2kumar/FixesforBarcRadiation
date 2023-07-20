using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchTrigger : MonoBehaviour
{
    public static TouchTrigger instance;
    public bool activate, triggerrecive;// recive bool active from oculus gloves
    public string TextLeft, TextRight, MainText;
    public HandsColliderValue ValueFromColliders;
    public void Start()
    {
        instance = this;
    }


    public void FixedUpdate()
    {
        TextLeft = ValueFromColliders.LeftString;
        TextRight = ValueFromColliders.RightString;
        MainText = TextLeft;
        MainText = TextRight;
        if (ValueFromColliders.LeftActive == true || ValueFromColliders.RightActive == true)
        {
            if(MainText == "")
            {

            }
        }
    }
}
