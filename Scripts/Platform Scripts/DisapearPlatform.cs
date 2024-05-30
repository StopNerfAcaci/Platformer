using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearPlatform : MonoBehaviour
{
    private float fallDelay = 1f;
    private float inActiveDelay = 0.5f;
    private float respawnDelay = 3f;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private bool isDestroyed;

    [SerializeField] private Rigidbody2D rb;
  
 
    void Start()
    {
        isDestroyed = false;
    }
    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private IEnumerator Fall()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
        isDestroyed = true;
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        yield return new WaitForSeconds(inActiveDelay);
        gameObject.SetActive(false);
        PlatformManager.Instance.ScheduleRespawn(this, respawnDelay);
    }
   public void RespawnPlaform()
    {
        if (isDestroyed)
        {
            transform.position = initialPosition;
            transform.rotation = initialRotation;
            rb.bodyType = RigidbodyType2D.Kinematic; // Reset to initial state if needed
            gameObject.SetActive(true);
            isDestroyed = false;
        }
    }

}
