using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BerryAnimation : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D bo;
    private Animator animator;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        bo = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerInventory pi = other.GetComponent<PlayerInventory>();
        if (pi != null)
        {
            pi.BerryCollect();
            gameObject.SetActive(false);
        }
    }


}
