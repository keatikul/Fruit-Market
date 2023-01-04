using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNextScene : MonoBehaviour
{
    private int nextSceneToLoad; 
    
    private void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    
    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneToLoad);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
