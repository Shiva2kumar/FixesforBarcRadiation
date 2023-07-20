using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnnerInmap : MonoBehaviour
{
    public int Range;
    public GameObject CobaltSpawners;
    public string texts;
    void Start()
    {
        Invoke("OBjectsSpawn",0.1f);
    }

    public void OBjectsSpawn()
    {
        Range = Random.Range(1, 3);
        for(int i = 0; i < Range; i++)
        {
            Instantiate(CobaltSpawners);
        }
    }
}
