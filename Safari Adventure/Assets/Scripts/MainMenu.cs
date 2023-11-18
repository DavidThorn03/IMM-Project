using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public void PlayBtn()
    {
        Debug.Log("Play Game");
        SceneManager.LoadScene(1);
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitBtn()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void InstBtn(int sceneID)
    {
        Debug.Log("Inststuctions");
        SceneManager.LoadScene(sceneID);
    }
}


