using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tongspawn : MonoBehaviour
{
    public GameObject TongTong;
    void Update()
    {
        TongTong = GameObject.Find("tong");
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            TongTong.transform.position = this.transform.position;
        }
    }
}
