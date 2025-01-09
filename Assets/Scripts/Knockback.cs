using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    private Vector2 bulletDir;
    public float knockbackTime = 0.2f;
    public float force = 10;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bulletDir = collision.gameObject.transform.forward;
        collision.attachedRigidbody.AddForce(bulletDir.normalized * force);
        Debug.Log("Applied Knockback");
    }

    private void Update()
    {
        Debug.Log(bulletDir);
    }
}
