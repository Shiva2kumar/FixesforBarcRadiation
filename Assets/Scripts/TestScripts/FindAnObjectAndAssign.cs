using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;

public class FindAnObjectAndAssign : MonoBehaviour
{
    public GameObject Lefthandintractiontransform, Righthandintractiontransform;
    public Rigidbody Rb;
    public Collider[] Coll;
    public Hands IntractedHand;
    public bool lefthandtrigger, rigthhandtrigger;
    public GameObject LeftSideColider, RightSideColider;
    public ControllerInputsManualBounds Inputmodule;
    public Vector3 lefthandV3Rot, rigthhandV3Rot;
    public GameObject PlayerCollider;


    public void Start()
    {
        PlayerCollider = GameObject.Find("OVRPlayerController Variant(Clone)");
    }
    public enum Hands
    {
        none,
        lefthand,
        righthand
    }
    private void LateUpdate()
    {
        Lefthandintractiontransform = GameObject.Find("LeftHandIntraction");
        Righthandintractiontransform = GameObject.Find("RightHandIntraction");
    }
    public void Update()
    {
        //Physics.IgnoreCollision(PlayerCollider);
        if (IntractedHand == Hands.lefthand)
        {
            
            if (Inputmodule.leftFloat >= 0.5f)
            {
                lefthandtrigger = true;///
            }
            else
            {
                lefthandtrigger = false;
            }
            if (lefthandtrigger == true)
            {
                this.transform.localPosition = Lefthandintractiontransform.transform.position;
                this.transform.localRotation = (Lefthandintractiontransform.transform.rotation) * (Quaternion.Euler(lefthandV3Rot.x,lefthandV3Rot.y,lefthandV3Rot.z));
                //this.transform.localRotation = Lefthandintractiontransform.transform.(Quaternion.Euler(lefthandV3.x,lefthandV3.y,lefthandV3.z);
            }
            else
            {
                this.transform.position = this.transform.localPosition;
                this.transform.rotation = this.transform.localRotation;
            }
        }
        else
        {
            Lefthandintractiontransform = null;
        }
        if (IntractedHand == Hands.righthand)
        {
            if (Inputmodule.rightFloat >= 0.5)
            {
                rigthhandtrigger = true;
            }
            else
            {
                rigthhandtrigger = false;
            }
            if (rigthhandtrigger == true)
            {
                this.transform.localPosition = Righthandintractiontransform.transform.position;
                this.transform.localRotation = (Righthandintractiontransform.transform.rotation) * (Quaternion.Euler(rigthhandV3Rot.x,rigthhandV3Rot.y,rigthhandV3Rot.z));
            }
            else
            {
                this.transform.position = this.transform.localPosition;
                this.transform.rotation = this.transform.localRotation;
            }
        }
        else
        {
            Righthandintractiontransform = null;
        }
        if (IntractedHand == Hands.none)
        {
            Lefthandintractiontransform = null;
            Righthandintractiontransform = null;
        }
    }
    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "hands:b_r_hand_ignore")
        {
            IntractedHand = Hands.righthand;
            Rb.useGravity = false;
            Rb.isKinematic = true;
            for(int i = 0; i < Coll.Length; i++)
            {
                Coll[i].enabled = false;
            }
        }
        else
        if (go.name == "hands:b_l_hand_ignore")
        {
            IntractedHand = Hands.lefthand;
            Rb.useGravity = false;
            Rb.isKinematic = true;
            for (int i = 0; i < Coll.Length; i++)
            {
                Coll[i].enabled = false;
            }
        }
        else
        {
            IntractedHand = Hands.none;
            Rb.useGravity = true;
            Rb.isKinematic = false;
            for (int i = 0; i < Coll.Length; i++)
            {
                Coll[i].enabled = true;
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {
        IntractedHand = Hands.none;
        Rb.useGravity = true;
        Rb.isKinematic = false;
        for (int i = 0; i < Coll.Length; i++)
        {
            Coll[i].enabled = true;
        }
    }
}
