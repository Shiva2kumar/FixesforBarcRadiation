using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class HanIntractions : MonoBehaviour
{
    public hands HandSide;
    public float TriggerL, TriggerR;
    public HandsColliderValue HandsColliderBool;
    public bool TriggerLActive, TriggerRActive;

    public GameObject cell;
    public enum hands
    {
        Left,
        Rights
    }

    public void Update()
    {
        TriggerL = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
        TriggerR = OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger);





        if(HandSide == hands.Left)
        {
            HandsColliderBool.SelectedHandLeft = HandsColliderValue.LHand.Left;
            if(TriggerLActive == true)
            {
                if(TriggerL >= 0.5)
                {
                    HandsColliderBool.LeftActive = true;
                }
                else
                {
                    HandsColliderBool.LeftActive = false;
                }
            }
            else
            {
                HandsColliderBool.LeftActive = false;
            }
        }
        


        if (HandSide == hands.Rights)
        {
            HandsColliderBool.SelectedHandRight = HandsColliderValue.RHand.Right;
            if (TriggerRActive == true)
            {
                if (TriggerR >= 0.5)
                {
                    HandsColliderBool.RightActive = true;
                }
                else
                {
                    HandsColliderBool.RightActive = false;
                }
            }
            else
            {
                HandsColliderBool.RightActive = false;
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;
        if(HandSide == hands.Left)
        {
            if (go.tag == "TriggerEnter")
            {
                TriggerLActive = true;
            }
            
            
                HandsColliderBool.LeftString = other.name;
            
            


            HandsColliderBool.HandLTriggerdValue = other.name;
        }
        if (HandSide == hands.Rights)
        {
            if (go.tag == "TriggerEnter")
            {
                TriggerRActive = true;
            }
            
                HandsColliderBool.RightString = other.name;
            
            
            HandsColliderBool.HandRTriggerdValue = other.name;
        }
        
    }


    public void OnTriggerExit(Collider other)
    {
        TriggerLActive = false;
        TriggerRActive = false;
        HandsColliderBool.LeftString = null;
        HandsColliderBool.RightString = null;
        HandsColliderBool.HandLTriggerdValue = null;
        HandsColliderBool.HandRTriggerdValue = null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "call")
        {
            cell.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        cell.SetActive(false);
    }


}
