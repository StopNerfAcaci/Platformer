using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpTutorial : MonoBehaviour
{
    public GameObject popUpTutorial;
    // Start is called before the first frame update
    void Awake()
    {
        if(popUpTutorial != null)
            popUpTutorial.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (popUpTutorial.activeSelf == true)
        {
            Time.timeScale = 0f;
        }
    }
    public void TutorialOff()
    {
        popUpTutorial.SetActive(false);
        Time.timeScale = 1f;
    }
}
