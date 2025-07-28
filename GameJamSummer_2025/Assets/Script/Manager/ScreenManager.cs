using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("Monitor_A Scene", LoadSceneMode.Additive);
        SceneManager.LoadScene("Monitor_B Scene", LoadSceneMode.Additive);
    }

    void Update()
    {
        
    }
}
