using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn3 : MonoBehaviour
{
    public GameObject[] objjj = new GameObject[4];
    public GameObject Co, Cs, co, cs;
    public Vector3[] positions = new Vector3[30];
    public int i, j, k, l, q;
    bool create, stop;
    public void Start()
    {
        q = Random.Range(0, 3);
        for (int s = 0; s <= q; s++)
        {
            objjj[s].SetActive(true);
        }
        create = true;
        positions[0] = new Vector3(-58.7000008f, 2, -8.69999981f);
        positions[1] = new Vector3(-48.2000008f, 2, -14.1999998f);
        positions[2] = new Vector3(-25.2000008f, 2, -14.1999998f);
        positions[3] = new Vector3(-28.6000004f, 2, -37);
        positions[4] = new Vector3(-4, 1, -35.7999992f);
        positions[5] = new Vector3(-4, 1, -47.4000015f);
        positions[6] = new Vector3(-4, 1, -65.8099976f);
        positions[7] = new Vector3(-4, 1, -91.8499985f);
        positions[8] = new Vector3(-54, 1, -78);
        positions[9] = new Vector3(-30.2399998f, 1, -38.0099983f);
        positions[10] = new Vector3(11, 1, -36.2999992f);
        positions[11] = new Vector3(-50.2200012f, 1, -75.5999985f);
        positions[12] = new Vector3(-25.2700005f, 1, 9.52999973f);
        positions[13] = new Vector3(-23.0340004f, 7.76800013f, 22.25f);
        positions[14] = new Vector3(-18.25f, 0.74000001f, 36);
        positions[15] = new Vector3(11.3999996f, 0.74000001f, 45.9000015f);
        positions[16] = new Vector3(4.9000001f, 0.74000001f, 73.5999985f);
        positions[17] = new Vector3(68, 0.74000001f, 23.7999992f);
        positions[18] = new Vector3(16.7000008f, 0.74000001f, 73.8000031f);
        positions[19] = new Vector3(-22.5f, 0.74000001f, -14.6099997f);
        positions[20] = new Vector3(-48.5400009f, 0.74000001f, -17.1700001f);
        positions[21] = new Vector3(-45.4700012f, 0.74000001f, -49.3199997f);
        positions[22] = new Vector3(-3.69000006f, 0.74000001f, -61.7000008f);
        positions[23] = new Vector3(31.4400005f, 0.74000001f, 54.9599991f);
        positions[24] = new Vector3(-22.8099995f, 0.74000001f, 7.40999985f);
        positions[25] = new Vector3(-46.5f, 0.74000001f, -76.7300034f);
        positions[26] = new Vector3(-55.2999992f, 0.74000001f, -64.7099991f);
        positions[27] = new Vector3(-93.5f, 0.74000001f, 6.98999977f);
        positions[28] = new Vector3(9.5f, 0.74000001f, 46.7000008f);
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
            co = Instantiate(objjj[0], positions[i], Quaternion.identity);
            Co = Instantiate(objjj[1], positions[j], Quaternion.identity);
            Cs = Instantiate(objjj[2], positions[k], Quaternion.identity);
            cs = Instantiate(objjj[3], positions[l], Quaternion.identity);
            create = false;
        }
    }
    public void OnDisable()
    {
        Destroy(cs);
        Destroy(Cs);
        Destroy(Co);
        Destroy(co);
        objjj[0].SetActive(false);
        objjj[1].SetActive(false);
        objjj[2].SetActive(false);
        objjj[3].SetActive(false);
    }
}
