using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject confirmMenu;
    public bool isPaused = false;
    public PlayerDeath playerDeath;
    [Header("Buttons")]
    public Button resumeButton;
    public Button retryButton;
    public Button exitButton;
    public Button returnButton;

    private Button selectedButton;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        confirmMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            if(isPaused)
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
    public void ConfirmReturn()
    {
        confirmMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void Retry()
    {
        playerDeath.Retry();
        ResumeGame() ;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
