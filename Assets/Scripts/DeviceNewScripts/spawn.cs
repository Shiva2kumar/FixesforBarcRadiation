using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;
public class spawn : MonoBehaviour
{
    public GameObject[] obj = new GameObject[4];
    public GameObject Co, Cs, co, cs;
    public Vector3[] positions = new Vector3[30];
    public int i, j, k, l,q;
    bool create, stop;
 public void Start()
    {
        q = Random.Range(0, 3);
        for (int s = 0; s <= q; s++)
        {
            obj[s].SetActive(true);
        }
        create = true;
        positions[0] = new Vector3(41, 0.5f, 3.91f);
        positions[1] = new Vector3(67, 0, 3);
        positions[2] = new Vector3(82, 0.5f, 5);
        positions[3] = new Vector3(82, 0.5f, -10);
        positions[4] = new Vector3(4, 0.5f, -20);
        positions[5] = new Vector3(7, 0.5f, -36);
        positions[6] = new Vector3(-10, 0.5f, -32);
        positions[7] = new Vector3(-4, 0.5f, -75);
        positions[8] = new Vector3(-5, 0, -94);
        positions[9] = new Vector3(-12, 7.360f, 37);
        positions[10] = new Vector3(-25, 0.772f, 23);
        positions[11] = new Vector3(13, 0.77f, 26);
        positions[12] = new Vector3(10, 0.772f, -41);
        positions[13] = new Vector3(-4, 1.179f, -21);
        positions[14] = new Vector3(-4, 2.31f, -42);
        positions[15] = new Vector3(-4, 1.75f, -59);
        positions[16] = new Vector3(4, 1.52f, -61);
        positions[17] = new Vector3(4, 1.52f, -41);
        positions[18] = new Vector3(4, 1.52f, -15);
        positions[19] = new Vector3(-20, 9.8f, 37);
        positions[20] = new Vector3(-4, 1, 91);
        positions[21] = new Vector3(-4, 1, 75);
        positions[22] = new Vector3(4, 1, 61);
        positions[23] = new Vector3(-4, 1, 87);
        positions[24] = new Vector3(-4, 1, 71);
        positions[25] = new Vector3(-4, 1, 26);
        positions[26] = new Vector3(9.96000004f, 1, 32.2799988f);
   /*     positions[27] = new Vector3(-42, 0.5f, 56);
        positions[28] = new Vector3(43, 0.5f, -66);
        positions[29] = new Vector3(6, 0.5f, 46);
        positions[30] = new Vector3(-20, 0.5f, 46);*/
    }
    private void Update()
    {
            positionselect1();  
    }
    public void positionselect1()
    {
        if (create == true)
        {
            i = Random.Range(0, 26);
            j = Random.Range(0, 26);
            k = Random.Range(0, 26);
            l = Random.Range(0, 26);
            co = Instantiate(obj[0], positions[i], Quaternion.identity);
            Co = Instantiate(obj[1], positions[j], Quaternion.identity);
            Cs = Instantiate(obj[2], positions[k], Quaternion.identity);
            cs = Instantiate(obj[3], positions[l], Quaternion.identity);
            create = false;
        }
    }
    public void OnDisable()
    {
        Destroy(cs);
        Destroy(Cs);
        Destroy(Co);
        Destroy(co);
        obj[0].SetActive(false);
        obj[1].SetActive(false);
        obj[2].SetActive(false);
        obj[3].SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (this.gameObject.tag == "Trolly")
        {
            Destroy(this.gameObject);
        }
    }
}
