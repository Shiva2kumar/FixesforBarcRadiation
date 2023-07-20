using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public int Range;
    void Start()
    {
        Invoke("SceneLoader", 5f);
    }

    public void SceneLoader()
    {
        Range = Random.Range(3, 7);
        SceneManager.LoadScene(Range);
    }
}
