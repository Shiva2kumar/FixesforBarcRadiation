using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWNN : MonoBehaviour
{
    public GameObject[] objj = new GameObject[4];
    public GameObject Coo, Css, coo, css;
    public Vector3[] positions = new Vector3[30];
    public int i, j, k, l, q;
    bool create, stop;
    public void Start()
    {
        q = Random.Range(0, 3);
        for (int s = 0; s <= q; s++)
        {
            objj[s].SetActive(true);
        }
        create = true;
        positions[0] = new Vector3(5.53999996f, 1, -42.262001f);
        positions[1] = new Vector3(5.53999996f, 1, -34.0499992f);
        positions[2] = new Vector3(14.6400003f, 1, -24.9300003f);
        positions[3] = new Vector3(11.0799999f, 1, -61.1199989f);
        positions[4] = new Vector3(-3.99000001f, 1, -75.7399979f);
        positions[5] = new Vector3(-3.99000001f, 1, -83.4700012f);
        positions[6] = new Vector3(6.98000002f, 1, -83.4700012f);
        positions[7] = new Vector3(-24.3700008f, 1, 8.13000011f);
        positions[8] = new Vector3(-21.3999996f, 8.77999973f, 29.4300003f);
        positions[9] = new Vector3(-36.8390007f, 1.46000004f, 16.5599995f);
        positions[10] = new Vector3(-24.6599998f, 1.46000004f, 66.1500015f);
        positions[11] = new Vector3(-88.8000031f, 1.46000004f, 57.0099983f);
        positions[12] = new Vector3(-75.8499985f, 1.46000004f, 41.9700012f);
        positions[13] = new Vector3(-33.6469994f, 1.46000004f, 54.9280014f);
        positions[14] = new Vector3(-21.5599995f, 1.46000004f, 54.9280014f);
        positions[15] = new Vector3(35.2999992f, 1.46000004f, 11.6999998f);
        positions[16] = new Vector3(86.6999969f, 1.46000004f, 57.9000015f);
        positions[17] = new Vector3(82.5f, 1.46000004f, 24.6000004f);
        positions[18] = new Vector3(35.4000015f, 1.46000004f, 10.1999998f);
        positions[19] = new Vector3(-70.7799988f, 1.46000004f, 45.9000015f);
        positions[20] = new Vector3(-13.8000002f, 1.46000004f, -72.0999985f);
        positions[21] = new Vector3(68.1999969f, 1.46000004f, 34.2999992f);
        positions[22] = new Vector3(4, 1.46000004f, -24.5499992f);
        positions[23] = new Vector3(4, 1.46000004f, -54.4500008f);
        positions[24] = new Vector3(4, 1.46000004f, -71.2699966f);
        positions[25] = new Vector3(35.4199982f, 1.46000004f, 4.9000001f);
        positions[26] = new Vector3(74.4100037f, 1.46000004f, 44.1500015f);
        positions[27] = new Vector3(37.2999992f, 1.46000004f, 10.8000002f);
        positions[28] = new Vector3(12.8000002f, 1.46000004f, -33.4000015f);
      
    }
    private void Update()
    {
        positionselect1();
    }
    public void positionselect1()
    {
        if (create == true)
        {
            i = Random.Range(0, 28);
            j = Random.Range(0, 28);
            k = Random.Range(0, 28);
            l = Random.Range(0, 28);
            coo = Instantiate(objj[0], positions[i], Quaternion.identity);
            Coo = Instantiate(objj[1], positions[j], Quaternion.identity);
            Css = Instantiate(objj[2], positions[k], Quaternion.identity);
            css = Instantiate(objj[3], positions[l], Quaternion.identity);
            create = false;
        }
    }
    public void OnDisable()
    {
        Destroy(css);
        Destroy(Css);
        Destroy(Coo);
        Destroy(coo);
        objj[0].SetActive(false);
        objj[1].SetActive(false);
        objj[2].SetActive(false);
        objj[3].SetActive(false);
    }
}
