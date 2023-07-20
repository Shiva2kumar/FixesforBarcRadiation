using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class Timer : MonoBehaviour
{
    public GameObject obj;
    public TextMeshProUGUI count;
    public float timee;
    public float increase;
    void Start()
    {
        
    //    timee = 1;
        increase = 1f;
    }
    void FixedUpdate()
    {
        if ((!obj.activeSelf))
        {
            timee = 0;
        }
        count.text = ((int)timee).ToString();
        timee += increase * Time.fixedDeltaTime;
    }
}