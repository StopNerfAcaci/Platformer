using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinLevel : MonoBehaviour
{
    public GameObject com;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(delay());

        }
    }

    private IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        com.SetActive(true);
        

    }
}
