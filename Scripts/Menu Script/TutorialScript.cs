using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScript : MonoBehaviour
{
    public GameObject popUpTutorial;
    // Start is called before the first frame update
    void Awake()
    {
        if (popUpTutorial != null)
            popUpTutorial.SetActive(true);
    }

    // Update is called once per frame  
    void Update()
    {
    }
    public void TutorialOff()
    {
        SceneManager.LoadScene("LevelSelection");
        Time.timeScale = 1f;
    }
}
