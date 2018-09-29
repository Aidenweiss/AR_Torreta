using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("EscenaTorreta");
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

