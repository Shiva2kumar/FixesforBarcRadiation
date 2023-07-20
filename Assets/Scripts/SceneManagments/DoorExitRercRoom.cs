using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class DoorExitRercRoom : MonoBehaviour
{
    public RERCtoScene ExitAndLoadNextSceneScript;
    public float timeRemaining = 10;
    public bool Loading, doorLoad;
    public Slider LoadingSlider;

    
    public void OnTriggerEnter(Collider other)
    {
        
        GameObject GO = other.gameObject;
        if(GO.name == "OVRPlayerController Variant(Clone)")
        {

            Loading = true;

        }
    }

    public void OnTriggerExit(Collider other)
    {
        GameObject GO = other.gameObject;
        if (GO.name == "OVRPlayerController Variant(Clone)")
        {

            Loading = false;

        }
    }

    public void Update()
    {
        if(MobilePhone.Instance.Doorsunlocked == true)
        {
            doorLoad = true;
        }

        if(doorLoad == true)
        {
            if (Loading == true)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }
            }
            else
            {
                timeRemaining = 10;
            }


            if (timeRemaining <= 0)
            {

                ExitAndLoadNextSceneScript.EnableScene = true;

            }

            LoadingSlider.value = timeRemaining;
        }
        
    }
}
