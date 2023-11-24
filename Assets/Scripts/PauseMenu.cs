using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void Resume()
    {
        SceneManager.LoadScene(0);
    }
    public void Menu()
    {
        SceneManager.LoadScene(4);
    }
    public void Quit()
    {
      Application.Quit();
    } 
}
