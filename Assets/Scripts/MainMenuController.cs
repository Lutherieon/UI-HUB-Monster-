using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour
{

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Continue()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
