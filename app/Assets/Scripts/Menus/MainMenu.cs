using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("LevelSelect");
    }
    public void Quit()
    {
        Debug.Log("Salio!!!");
        Application.Quit();
    }
}
