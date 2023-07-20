using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Spawn4 : MonoBehaviour
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
        positions[0] = new Vector3(11.2600002f, 1, -50.6100006f);
        positions[1] = new Vector3(-4, 1, -59.1100006f);
        positions[2] = new Vector3(-4, 1, -23.3299999f);
        positions[3] = new Vector3(-15.29f, 1, 19);
        positions[4] = new Vector3(3.1500001f, 1, 76.0650024f);
        positions[5] = new Vector3(12.1599998f, 1, 50.5200005f);
        positions[6] = new Vector3(-45.7070007f, 1, 0.0299999993f);
        positions[7] = new Vector3(-67.1600037f, 1, 0.230000004f);
        positions[8] = new Vector3(-73, 1, 8.52000046f);
        positions[9] = new Vector3(-73, 1, 28.1000004f);
        positions[10] = new Vector3(-73, 1, 70.7399979f);
        positions[11] = new Vector3(-73, 1, 91.4599991f);
        positions[12] = new Vector3(-82.0699997f, 1, 8.76000023f);
        positions[13] = new Vector3(-35.9000015f, 1, -17.2999992f);
        positions[14] = new Vector3(59.6500015f, 1, -4);
        positions[15] = new Vector3(89.7600021f, 1, 3.5f);
        positions[16] = new Vector3(73, 1, 35.3100014f);
        positions[17] = new Vector3(14.1000004f, 1, 47.9000015f);
        positions[18] = new Vector3(-26.7800007f, 1, 20.6399994f);
        positions[19] = new Vector3(-15.1300001f, 8.36999989f, 37.3100014f);
        positions[20] = new Vector3(-71, 1, 88.4599991f);
        positions[21] = new Vector3(-4, 1, -43.6699982f);
        positions[22] = new Vector3(-4, 1, -75.1999969f);
        positions[23] = new Vector3(14.5600004f, 1, -15.7600002f);
        positions[24] = new Vector3(-89.6999969f, 1, -3.43000007f);

        positions[25] = new Vector3(-83.9300003f, 1, 49.5699997f);
        positions[26] = new Vector3(-82.1900024f, 1, 67.3000031f);
        positions[27] = new Vector3(-59.5f, 1, 59.7299995f);

    }
    private void Update()
    {
        positionselect1();
    }
    public void positionselect1()
    {
        if (create == true)
        {
            i = Random.Range(0, 27);
            j = Random.Range(0, 27);
            k = Random.Range(0, 27);
            l = Random.Range(0, 27);
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
