using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LevelOne()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Game");
    }

    public void LevelTwo()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("lvl2");
    }

    public void Party()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Party");
    }

    public void Back()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }

   


}
