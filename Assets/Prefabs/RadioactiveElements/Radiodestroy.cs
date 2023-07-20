using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.WSA;

public class Radiodestroy : MonoBehaviour
{
    public float distance;
    private void OnTriggerEnter(Collider other)
    {
        GameObject go = GameObject.Find("Holder");
        
        distance = Vector3.Distance(this.transform.position, go.transform.position);
        if ((distance < 0.9f)) //&& ((OVRInput.Get(OVRInput.RawButton.Y)) || ((OVRInput.Get(OVRInput.RawButton.B)))))
        {
            Destroy(this.gameObject);
        }
    }
}




