using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused = false;
    public PlayerDeath playerDeath;

    void Awake()
    {
        if (pauseMenu != null)
        {
            pauseMenu.SetActive(false);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isPaused)
            {

                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void Retry()
    {
        playerDeath.Retry();
        ResumeGame();
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void GoToMain()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("GameMenu");
        isPaused = false;

    }
}
