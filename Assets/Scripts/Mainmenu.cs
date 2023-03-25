using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mainmenu : MonoBehaviour
{
    public GameObject settings;
    public GameObject menu;
    void Start() 
    {
        menu.SetActive(true);
        settings.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Settings()
    {
        menu.SetActive(false);
        settings.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void BacktoMenu()
    {
        menu.SetActive(true);
        settings.SetActive(false);
    }
}