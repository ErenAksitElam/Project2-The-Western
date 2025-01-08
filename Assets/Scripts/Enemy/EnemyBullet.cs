using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Vector2 moveDirection;
    private float moveSpeed;
    private Rigidbody2D rb;

    private void OnEnable()
    {
        Invoke("Destroy", 3f);
    }
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Environment")
        {
            Destroy();
        }
    }

    private void Destroy()
    {
       gameObject.SetActive(false); 
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void CheckDirection()
    {
        if (GetComponent<Rigidbody>().velocity.x > 0.3 || GetComponent<Rigidbody>().velocity.y > 0.3 || GetComponent<Rigidbody>().velocity.z > 0.3)
            transform.LookAt(transform.position + GetComponent<Rigidbody>().velocity);
    }
}
