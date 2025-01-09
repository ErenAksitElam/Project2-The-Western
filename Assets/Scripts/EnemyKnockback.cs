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
            knockbackVelocity = collision.transform.position;

            rb.AddForce(knockbackVelocity * 500);
        }
    }

    private void Update()
    {
        Debug.Log(knockbackVelocity);
        Debug.Log(knockbackForce);
    }
}
