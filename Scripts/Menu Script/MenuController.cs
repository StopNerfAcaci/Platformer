using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    private const string TutorialShownKey = "TutorialShown";
    private void Start()
    {

    }
    public void LoadScene()
    {
        if (PlayerPrefs.GetInt(TutorialShownKey, 0) == 0)
        {
            SceneManager.LoadScene("Tutorial");
            PlayerPrefs.SetInt(TutorialShownKey, 1);
            //PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
        else
        {
            SceneManager.LoadScene("LevelSelection");
        }
        Debug.Log(PlayerPrefs.GetInt(TutorialShownKey).ToString());

    }
    public void ClearTutorialShown()
    {
        // Deletes the "TutorialShown" key
        PlayerPrefs.DeleteKey("TutorialShown");
        PlayerPrefs.Save();
        Debug.Log("TutorialShown key has been cleared.");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
