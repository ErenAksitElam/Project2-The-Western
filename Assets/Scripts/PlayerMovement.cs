using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 7.5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] float bulletLife = 3f;

    public float bulletSpeed = 10f;
    public static float originalAmmo = 6f;
    private float ammo = originalAmmo;
    private bool isReloading = false;

    private Rigidbody2D rb;

    private Vector2 movementDirection;

    private float horizontal;
    private float vertical;

    public TMP_Text ammoText;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
}

    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        GunShooting();
        ammoText.SetText(ammo.ToString());
    }

    private void FixedUpdate()
    {
        rb.velocity = movementDirection * movementSpeed;
    }

    private void GunShooting()
    {
        if(ammo != 0 && !isReloading)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                GameObject bulletInst = Instantiate(bullet, transform.position, Quaternion.identity);
                Rigidbody2D bulletInstRB = bulletInst.GetComponent<Rigidbody2D>();
                bulletInstRB.AddForce(gameObject.transform.right * bulletSpeed);
                ammo -= 1;
                Destroy(bulletInst, bulletLife);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GameObject bulletInst = Instantiate(bullet, transform.position, Quaternion.identity);
                Rigidbody2D bulletInstRB = bulletInst.GetComponent<Rigidbody2D>();
                bulletInstRB.AddForce(-gameObject.transform.right * bulletSpeed);
                ammo -= 1;
                Destroy(bulletInst, bulletLife);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                GameObject bulletInst = Instantiate(bullet, transform.position, Quaternion.identity);
                Rigidbody2D bulletInstRB = bulletInst.GetComponent<Rigidbody2D>();
                bulletInstRB.AddForce(gameObject.transform.up * bulletSpeed);
                ammo -= 1;
                Destroy(bulletInst, bulletLife);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                GameObject bulletInst = Instantiate(bullet, transform.position, Quaternion.identity);
                Rigidbody2D bulletInstRB = bulletInst.GetComponent<Rigidbody2D>();
                bulletInstRB.AddForce(-gameObject.transform.up * bulletSpeed);
                ammo -= 1;
                Destroy(bulletInst, bulletLife);
            }
        }
        else if (ammo == 0 && !isReloading)
        {
            isReloading = true;
            StartCoroutine(ReloadWait());
        }
    }

    IEnumerator ReloadWait()
    {
        isReloading = true;
        yield return new WaitForSeconds(3.5f);
        ammo = originalAmmo;
        yield return new WaitForSeconds(0.5f);
        isReloading = false;
    }
}
