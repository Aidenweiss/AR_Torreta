using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
    }

    public void Men()
    {
        SceneManager.LoadScene("Menu");
    }

    public void EXITGAME()
    {
        Application.Quit();
    }
}

