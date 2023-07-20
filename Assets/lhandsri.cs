using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lhandsri : MonoBehaviour
{
    public GameObject talk;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "call")
        {
            talk.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        talk.SetActive(false);
    }

}
