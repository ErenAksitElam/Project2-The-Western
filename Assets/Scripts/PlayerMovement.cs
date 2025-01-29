using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Pathfinding.Util;
using UnityEditor.Experimental.GraphView;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 7.5f;
    [SerializeField] private GameObject bullet;
    [SerializeField] float bulletLife = 3f;

    public float bulletSpeed = 90f;
    public static float originalAmmo = 6f;
    private float ammo = originalAmmo;
    public bool isReloading = false;

    private Rigidbody2D rb;

    private Vector2 movementDirection;

    private float horizontal;
    private float vertical;

    public float HP = 10;

    public float dashSpeed = 10f;
    public float dashDuration = 1f;
    public float dashCooldown = 1f;
    bool isDashing;
    bool canDash = true;

    public Standoff2 Standoff2Script;

    public GameObject[] HealthBars;

    private int currentIndex;

    private bool iFrame;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        canDash = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Standoff2Script.standoff == false)
        {
            if (isDashing)
            {
                return;
            }

            movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            GunShooting();

            if (HP <= 0)
            {
                SceneManager.LoadScene("DeathScreen");
            }

            if (Input.GetKeyDown(KeyCode.Space) && canDash)
            {
                StartCoroutine(Dash());
            }

            if (isDashing)
            {
                StartCoroutine(Invincibility());
            }
        }
    }

    private void FixedUpdate()
    {
        if (Standoff2Script.standoff == false)
        {
            if (isDashing)
            {
                return;
            }
            rb.velocity = movementDirection * movementSpeed;
        }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isDashing == false)
        {
            if (collision.gameObject.tag == "EnemyBullet" && !iFrame)
            {
                HP -= 1;
                currentIndex += 1;

                DisableHealthBars();
                HealthBars[currentIndex].SetActive(true);
                StartCoroutine(Invincibility());
            }
        }
    }

    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        rb.velocity = new Vector2(movementDirection.x * dashSpeed, movementDirection.y * dashSpeed);
        yield return new WaitForSeconds(dashDuration);
        isDashing = false;

        yield return new WaitForSeconds(dashCooldown);
        canDash = true;
    }

    private void DisableHealthBars()
    {
        for (int i = 0; i < HealthBars.Length; i++)
        {
            HealthBars[i].SetActive(false);
        }
    }

    private IEnumerator Invincibility()
    {
        iFrame = true;
        yield return new WaitForSeconds(0.5f);
        iFrame = false;
    }
}