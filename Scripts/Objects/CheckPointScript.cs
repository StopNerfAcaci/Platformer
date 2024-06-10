using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointScript : MonoBehaviour
{
    private PlayerDeath respawn;
    private void Awake()
    {
        respawn = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDeath>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            respawn.UpdateCheckPoint(transform.position);
        }
    }


}
