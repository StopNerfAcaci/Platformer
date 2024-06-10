using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneWayPlatform : MonoBehaviour
{
    private GameObject currentOneWayPlatform;
    [SerializeField] private CapsuleCollider2D coll;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)){
            if(currentOneWayPlatform != null)
            {
                StartCoroutine(DisableCollision());
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OneWayPlatform"))
        {
            currentOneWayPlatform = collision.gameObject;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("OneWayPlatform"))
        {
            currentOneWayPlatform = null;
        }
    }
    private IEnumerator DisableCollision()
    {
        BoxCollider2D platformColl = currentOneWayPlatform.GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(coll, platformColl);
        yield return new WaitForSeconds(.25f);
        Physics2D.IgnoreCollision(coll, platformColl, false);
    }
}
