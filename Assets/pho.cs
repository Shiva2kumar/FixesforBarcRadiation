using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pho : MonoBehaviour
{
  public OVRCameraRig cameraRig;
  public  Vector3 position;
  public  Quaternion headsetRotation;
  public GameObject colll;

    void Start()
    {
      
    }
    void Update()
    {
        /*  cameraRig = GetComponent<OVRCameraRig>();
          headsetPosition = cameraRig.centerEyeAnchor.position;
          headsetRotation = cameraRig.centerEyeAnchor.rotation;
          colll.gameObject.transform.localPosition = headsetPosition;
          colll.gameObject.transform.localRotation = headsetRotation;*/

        this.gameObject.transform.position = colll.transform.position+new Vector3(0,0,150);
    }
}