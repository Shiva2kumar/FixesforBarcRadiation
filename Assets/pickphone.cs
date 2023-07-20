using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickphone : MonoBehaviour
{
    public GameObject talk;
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "callll")
        {
            talk.SetActive(true);
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        talk.SetActive(false);
    }

}
