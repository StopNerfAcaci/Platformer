using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private PolygonCollider2D co;
    private Animator animator;
    [HideInInspector]
    public float respawnTime = 3f;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        co = GetComponent<PolygonCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Movement player = other.GetComponent<Movement>();
            if (player != null)
            {
                player.RefillDash();
            }

            StartCoroutine(HideAndRespawn(respawnTime));
        }
    }

    public IEnumerator HideAndRespawn(float respawnTime)
    {
        spriteRenderer.enabled = false;
        co.enabled = false;

        yield return new WaitForSeconds(respawnTime);

        spriteRenderer.enabled = true;
        co.enabled = true;
    }
}
