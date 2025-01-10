using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class EnemyKnockback : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 knockbackForce;
    Vector2 knockbackVelocity;
    Vector2 knockbackReverse;

    private bool isKnockedBack = false;
    public Behaviour AIPath;
    public Behaviour AIDestinationSetter;

    public float knockbackTime = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*
        if (collision.gameObject.tag == "PlayerBullet")
        {

            Vector2 difference = (transform.position - collision.transform.position).normalized;
            Vector2 force = difference * knockbackForce;
            rb.AddForce(force, ForceMode2D.Impulse);

            collision.gameObject.SetActive(false);
        }
        */
        if (collision.gameObject.tag == "PlayerBullet")
        {
            if (!isKnockedBack == false)
            {
                isKnockedBack = true;
                knockbackVelocity = collision.transform.position;

                rb.AddForce(knockbackVelocity * 250);
                StartCoroutine(ResetKnockback());
            }
        }

        if (collision.gameObject.tag == "Environment")
        {
            isKnockedBack = false;
        }
    }

    private IEnumerator ResetKnockback()
    {
        yield return new WaitForSeconds(knockbackTime);
        isKnockedBack = false;
    }

    private void Update()
    {
        if (isKnockedBack == true)
        {
            AIPath.enabled = false;
            AIDestinationSetter.enabled = false;
        }
        else
        {
            AIPath.enabled = true;
            AIDestinationSetter.enabled = true;
        }
    }
}
