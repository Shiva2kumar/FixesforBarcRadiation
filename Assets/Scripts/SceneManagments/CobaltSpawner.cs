using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CobaltSpawner : MonoBehaviour
{
    public GameObject RadioActiveObjects,InstanceObjects;
    public int fR1A, fR1B, fR2A, fR2B, height;
    
    public void Start()
    {
        Vector3 RandomeSpawnPoints = new Vector3(Random.Range(fR1A, fR1B), height, Random.Range(fR2A, fR2B));
        InstanceObjects = Instantiate(RadioActiveObjects, RandomeSpawnPoints,Quaternion.identity);
    }
    public void OnDisable()
    {
        Destroy(InstanceObjects);
    }
}
