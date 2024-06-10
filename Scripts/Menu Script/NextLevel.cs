using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //private bool confirm;
    public void NextLv()
    {
        //confirm = true;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void selectlv()
    {
        SceneManager.LoadScene(2);
    }
}
