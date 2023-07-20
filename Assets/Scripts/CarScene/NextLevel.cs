using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    int i;
    public float timeRemaining=10;
    public bool Loading;
    void Start()
    {
        Loading = false;
    }
    void Update()
    {
        if (Loading == true)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
        }
        else
        {
            timeRemaining = 10;
        }
    //    if (timeRemaining <= 0)
        {
       //     Scenechange();
        //    ExitAndLoadNextSceneScript.EnableScene = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject GO = other.gameObject;
        if (GO.name == "OVRPlayerController Variant(Clone)")
        {
            Loading = true;

            Scenechange();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        GameObject GO = other.gameObject;
        if (GO.name == "OVRPlayerController Variant(Clone)")
        {
            Loading = false;
        }
    }

    public void Scenechange()
    {
        i = Random.Range(5, 6);
        SceneManager.LoadScene(i);
        Debug.Log(i);
    }
}
