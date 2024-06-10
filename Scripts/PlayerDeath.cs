using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public Vector2 checkPointPos;
    private Rigidbody2D rb;
    private AnimationScript anim;
    private Movement move;
    public int deathCount;

    public static event Action OnPlayerDeath;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        checkPointPos = transform.position;
        anim = GetComponentInChildren<AnimationScript>();
        move = GetComponentInChildren<Movement>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }
    public void Die()
    {
        anim.SetTrigger("die");
        move.isDead = true;
        move.canMove = false;
        deathCount++;
        Debug.Log(deathCount);
        StartCoroutine(Respawn(0.5f));
        OnPlayerDeath?.Invoke();
        
    }
    public void Retry()
    {
        StartCoroutine(Respawn(0));
        deathCount++;

    }
    IEnumerator Respawn(float duration)
    {
        rb.velocity = new Vector2(0, 0);
        rb.bodyType = RigidbodyType2D.Static;
        rb.gravityScale = 0f;
        yield return new WaitForSeconds(duration);
        rb.bodyType = RigidbodyType2D.Dynamic;
        transform.position = checkPointPos;
        move.isDead = false;
        move.canMove= true;
    }
    public void UpdateCheckPoint(Vector2 pos)
    {
        checkPointPos = pos;
    }

}
