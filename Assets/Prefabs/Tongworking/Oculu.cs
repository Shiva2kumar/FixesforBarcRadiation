using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oculu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        {
    //        GameObject player = GameObject.FindGameObjectWithTag("cs60");
    //        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("catch"))
        {
            Debug.Log("hello");
            this.gameObject.transform.position = other.gameObject.transform.position;
        
        }
    }
}
