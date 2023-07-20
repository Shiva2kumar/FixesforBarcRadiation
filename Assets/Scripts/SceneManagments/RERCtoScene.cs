using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RERCtoScene : MonoBehaviour
{
    public static RERCtoScene Instance { get; private set; }
    public bool EnableScene;
    public int scenenumber;
    private void Start()
    {
        EnableScene = false;
        Instance = this;
    }
    public void Update()
    {
        if(EnableScene == true)
        {
            LoadScene();
        }
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(scenenumber);
    }
}
