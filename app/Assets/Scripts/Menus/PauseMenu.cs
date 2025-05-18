using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour

{
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject pauseMenu;

    private bool pauseGame = false;
    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (pauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
       pauseGame= true;
        Time.timeScale=0;
        pauseButton.SetActive(false);
        pauseMenu.SetActive(true);
    }

    //Reanudar
    public void Resume()
    {
        pauseGame = false;
        Time.timeScale=1f;
        pauseButton.SetActive(true);
        pauseMenu.SetActive(false);
    }

    //Reiniciar
    public void Restart()
    {
        pauseGame = false;
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
