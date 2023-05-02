using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void startButton()
    {
        SceneManager.LoadScene("AR-Scene");
    }

    public void exitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void backButton()
    {
        SceneManager.LoadScene("Cover-Scene");
    }

    public void amerikaButton()
    {
        SceneManager.LoadScene("Amerika-Scene");
    }

    public void indonesiaButton()
    {
        SceneManager.LoadScene("Indonesia-Scene");
    }
    
    public void australiaButton()
    {
        SceneManager.LoadScene("Australia-Scene");
    }

    public void perancisButton()
    {
        SceneManager.LoadScene("Perancis-Scene");
    }

}

