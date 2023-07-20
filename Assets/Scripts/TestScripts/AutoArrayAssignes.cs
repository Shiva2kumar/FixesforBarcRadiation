using Oculus.Platform.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoArrayAssignes : MonoBehaviour
{
    public GameObject[] EnemiesArray, SpawnedObjects;
    public GameObject Holder;

    public int totalitems = 0;
    public void Start()
    {
        totalitems = Holder.transform.childCount;
        EnemiesArray = new GameObject[totalitems];

        for(int i = 0; i < totalitems; i++)
        {
            EnemiesArray[i] = Holder.transform.GetChild(i).gameObject;
            Instantiate(EnemiesArray[i]);
        }
    }

    
    public void Update()
    {
        
    }
}
