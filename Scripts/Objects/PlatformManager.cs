using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public static PlatformManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ScheduleRespawn(DisapearPlatform platform, float delay)
    {
        StartCoroutine(RespawnCoroutine(platform, delay));
    }

    private IEnumerator RespawnCoroutine(DisapearPlatform platform, float delay)
    {
        yield return new WaitForSeconds(delay);
        platform.RespawnPlaform();
    }
}
