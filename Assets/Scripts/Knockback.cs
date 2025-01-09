using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    private Vector2 bulletDir;
    public float knockbackTime = 1f;
    public float force = 10000;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bulletDir = collision.gameObject.transform.position;
        rb.AddForce(bulletDir * force);
        Debug.Log("Applied Knockback");
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(knockbackTime);
        rb.velocity = Vector2.zero;
    }

    private void Update()
    {
        Debug.Log(bulletDir);
    }
}
