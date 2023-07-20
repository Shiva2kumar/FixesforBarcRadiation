using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadRERCRoom : MonoBehaviour
{
    public float Timer;
    public int scenenumber;
    void Start()
    {
        Invoke("ToRERCRoom", Timer);
    }

    // Update is called once per frame
    public void ToRERCRoom()
    {
        SceneManager.LoadScene(scenenumber);
    }
}
