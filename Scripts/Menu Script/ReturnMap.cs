using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMap : MonoBehaviour
{
    private PauseMenuScript pauseScript;
    private bool confirm = false;
    private void Awake()
    {
        pauseScript = GetComponentInParent<PauseMenuScript>();
    }
    public void Cancel()
    {
        pauseScript.confirmMenu.SetActive(false);
        pauseScript.pauseMenu.SetActive(true);
        confirm = false;
    }
    public void GoToMain()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
