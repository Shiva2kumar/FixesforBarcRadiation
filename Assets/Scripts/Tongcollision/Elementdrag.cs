using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Elementdrag : MonoBehaviour
{
    public BoxCollider colli;
    public GameObject pin;
    public float distance;
    public GameObject ObjectSD;
    public void Start()
    {
        GameObject go = GameObject.Find("Full_size_printing_assembly.002");
        ObjectSD = go;
    }

    public void Update()
    {
        ////////       this.gameObject.transform.position = other.gameObject.transform.position;
        distance = Vector3.Distance(this.transform.position, ObjectSD.transform.position);

        if ((distance < 1.5f) && ((OVRInput.Get(OVRInput.RawButton.Y)) || ((OVRInput.Get(OVRInput.RawButton.B)))))
        {
            this.gameObject.transform.position = ObjectSD.gameObject.transform.position;
        }
    }

    
    
}

