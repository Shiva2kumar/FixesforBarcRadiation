using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trollyspan : MonoBehaviour
{
    public GameObject Trollspan;
    void Update()
    {
        Trollspan = GameObject.Find("Trollycarwithtang");
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            Trollspan.transform.position = this.transform.position;
        }
    }
}
