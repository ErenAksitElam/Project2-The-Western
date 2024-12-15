using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 7.5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] float bulletLife = 3f;

    public float bulletSpeed = 10f;

    private Rigidbody2D rb;

    private Vector2 movementDirection;

    private float horizontal;
    private float vertical;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        GunShooting();
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }

    private void GunShooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //spawn bullet
            GameObject bulletInst = Instantiate(bullet, transform.position, Quaternion.identity);
            Rigidbody2D bulletInstRB = bulletInst.GetComponent<Rigidbody2D>();

            if(horizontal == 1)
            {
                bulletInstRB.AddForce(gameObject.transform.right * bulletSpeed);
                Destroy(bulletInst, bulletLife);
            }
            if(horizontal == -1)
            {
                bulletInstRB.AddForce(-gameObject.transform.right * bulletSpeed);
                Destroy(bulletInst, bulletLife);
            }

            if(vertical == 1)
            {
                bulletInstRB.AddForce(gameObject.transform.up * bulletSpeed);
                Destroy(bulletInst, bulletLife);
            }

            if(vertical == -1)
            {
                bulletInstRB.AddForce(-gameObject.transform.up * bulletSpeed);
                Destroy(bulletInst, bulletLife);
            }
            
        }
    }
}
