using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.XR;
//using UnityEditor.Callbacks;

public class text : MonoBehaviour
{
    public TextMeshProUGUI textcomponent;
    public string[] lines;
    public float TextSpeed;
    private int index;
    public GameObject PlayerColliderr,obj;
    
    public OVRCameraRig cameraRig;
    public Vector3 headsetPosition;
    public Quaternion headsetRotation;
   
    void Start()
    {

    }
    void Update()
    {
        PlayerColliderr = GameObject.Find("OVRCameraRig");
        OVRCameraRig s2 = PlayerColliderr.GetComponent<OVRCameraRig>();
        //  cameraRig = GetComponent<OVRCameraRig>();
        /*   //   if((OVRInput.Get(OVRInput.Button.One))||(OVRInput.Get(OVRInput.Button.Three)))
              {
                  if (textcomponent.text == lines[index])
                  {
           //           nextline();
                  }
                  else
                  {
                      StopAllCoroutines();
                      textcomponent.text = lines[index];
                  }

              }*/
        headsetPosition = s2.centerEyeAnchor.position;
        headsetRotation = s2.centerEyeAnchor.rotation;
        this.gameObject.transform.position = headsetPosition;
        this.gameObject.transform.localRotation = headsetRotation;
        this.gameObject.transform.position = obj.transform.position;
       
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "call")
        {
            textcomponent.text = string.Empty;
            StartDialog();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        this.gameObject.SetActive(false);
    }
    public void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach(char c in lines[index].ToCharArray())
        {
            textcomponent.text += c;
            yield return new WaitForSeconds(TextSpeed);
        }
    }
    public void nextline()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textcomponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
          //StopAllCoroutines();
            this.gameObject.SetActive(false);
        }
    }
}
