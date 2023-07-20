using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn5 : MonoBehaviour
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
        positions[0] = new Vector3(51.9900017f, 1, -3);
        positions[1] = new Vector3(24.2399998f, 1,-4);
        positions[2] = new Vector3(34.4000015f, 1, 3.88000011f);
        positions[3] = new Vector3(74.5f, 1, 13.3000002f);
        positions[4] = new Vector3(45.4000015f, 1, 60.7000008f);
        positions[5] = new Vector3(36.0900002f, 1, 3.74000001f);
        positions[6] = new Vector3(-4, 1, -75.2900009f);
        positions[7] = new Vector3(-4, 1, -55.6500015f);
        positions[8] = new Vector3(4, 1, -46.7200012f);
        positions[9] = new Vector3(-6, 1, 21.8700008f);
        positions[10] = new Vector3(-23.4899998f, 1, 21.2399998f);
        positions[11] = new Vector3(-22.6599998f, 5.30999994f, 40.7299995f);
        positions[12] = new Vector3(34.7999992f, 1, 16.8999996f);
        positions[13] = new Vector3(-44.5f, 1, -0.5f);
        positions[14] = new Vector3(-60.5f, 1, 15.8999996f);
        positions[15] = new Vector3(-60.5f, 1, -45.9000015f);
        positions[16] = new Vector3(-52.7000008f, 1, -16.6000004f);
        positions[17] = new Vector3(52.2000008f, 1, 37.5f);
        positions[18] = new Vector3(52.2000008f, 1, 72.4000015f);
        positions[19] = new Vector3(83.75f, 1, 72.4000015f);
        positions[20] = new Vector3(83.75f, 1, 60.4500008f);
        positions[21] = new Vector3(83.75f, 1, 37.5200005f);
        positions[22] = new Vector3(75.3700027f, 1, 12.5900002f);
        positions[23] = new Vector3(-63.7299995f, 1, 14.4700003f);
        positions[24] = new Vector3(-74.5699997f, 1, 61.6500015f);
    }
    private void Update()
    {
        positionselect1();
    }
    public void positionselect1()
    {
        if (create == true)
        {
            i = Random.Range(0, 24);
            j = Random.Range(0, 24);
            k = Random.Range(0, 24);
            l = Random.Range(0, 24);
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
