using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhandsri : MonoBehaviour
{
    public GameObject talkk;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "call")
        {
            talkk.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        talkk.SetActive(false);
    }
}
