using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SceneLoad(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
