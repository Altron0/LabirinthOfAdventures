using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    void MenuScene() 
    {
        SceneManager.LoadScene("MenuScene");
    }

    void PlaygroundScene() 
    {
        SceneManager.LoadScene("PlaygroundScene");
    }

    void ExitGame() 
    {
        Application.Quit();
    }
}
