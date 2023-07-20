using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColliderDetectorForVan : MonoBehaviour
{
    public RERCtoScene VanTrigger;
    public ControllerInputsManualBounds InputBoundsController;
    public bool ColliderActive, ButtonPressed, Loading;
    public float Left, Right, timeRemaining = 10f;
    public GameObject CanvasScene;
    public Slider _slider;
    public void OnTriggerEnter(Collider other)
    {
        GameObject go = other.gameObject;

        if(go.name == "hands:b_l_hand_ignore" || go.name == "hands:b_r_hand_ignore")
        {
            ColliderActive = true;
        }
    }


    public void OnTriggerExit(Collider other)
    {
        GameObject go = other.gameObject;
        if (go.name == "hands:b_l_hand_ignore" || go.name == "hands:b_r_hand_ignore")
        {
            ColliderActive = false;
        }
    }


    public void Update()
    {
      Left  = InputBoundsController.leftFloat;
      Right = InputBoundsController.rightFloat;


        if (ColliderActive == true)
        {
            CanvasScene.SetActive(true);
            if(Left >= 0.8)
            {
                //VanTrigger.EnableScene = true;
            }
        }
        else
        {
            CanvasScene.SetActive(false);
            VanTrigger.EnableScene = false;
        }


        if (ColliderActive == true)
        {
            CanvasScene.SetActive(true);
            if (Right >= 0.8)
            {
                //VanTrigger.EnableScene = true;
                Loading = true;
            }
        }
        else
        {
            CanvasScene.SetActive(false);
            VanTrigger.EnableScene = false;
            Loading = false;
        }

        StartTimmer();
    }


    public void StartTimmer()
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

            VanTrigger.EnableScene = true;

        }

        _slider.value = timeRemaining;
    }
}
