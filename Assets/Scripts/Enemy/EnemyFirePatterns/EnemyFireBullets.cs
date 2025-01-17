using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireBullets : MonoBehaviour
{
    [SerializeField]
    private int bulletsAmount = 10;

    [SerializeField]
    private float startAngle = 90f, endAngle = 270f;

    private Vector2 bulletMoveDirection;

    private float angle = 0f;

    public int selectedPattern;
    private bool hasAttacked = false;

    public Standoff2 Standoff2Script;

    private void Start()
    {
        int selectedPattern = Random.Range(0, 5);
    }

    private void Update()
    {
        if (Standoff2Script.standoff == false)
        {
            int selectedPattern = Random.Range(0, 5);

            if (selectedPattern == 1 && hasAttacked == false)
            {
                FirePattern1();
            }
            else if (selectedPattern == 2 && hasAttacked == false)
            {
                FirePattern2();
            }
            else if (selectedPattern == 3 && hasAttacked == false)
            {
                FirePattern3();
            }
            else if (selectedPattern == 4 && hasAttacked == false)
            {
                FirePattern4();
            }
        }
    }

    private void FirePattern1Core()
    {
        float angleStep = (endAngle - startAngle) / bulletsAmount;
        float angle = startAngle;

        for (int i = 0; i < bulletsAmount + 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
                bul.transform.position = transform.position;
                bul.transform.rotation = transform.rotation;
                bul.SetActive(true);
                bul.GetComponent<EnemyBullet>().SetMoveDirection(bulDir);

            angle += angleStep;
        }
    }
    private void FirePattern1()
    {
        InvokeRepeating("FirePattern1Core", 0f, 2f);
        StartCoroutine(ChangeWait());
    }

    private void FirePattern2Core()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<EnemyBullet>().SetMoveDirection(bulDir);

        angle += 10f;
    }
    private void FirePattern2()
    {
        InvokeRepeating("FirePattern2Core", 0f, 0.1f);
        StartCoroutine(ChangeWait());
    }

    private void FirePattern3Core()
    {
        float bulDirX = transform.position.x + Mathf.Sin((angle * Mathf.PI) / 180f);
        float bulDirY = transform.position.y + Mathf.Cos((angle * Mathf.PI) / 180f);

        Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
        Vector2 bulDir = (bulMoveVector - transform.position).normalized;

        GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
        bul.transform.position = transform.position;
        bul.transform.rotation = transform.rotation;
        bul.SetActive(true);
        bul.GetComponent<EnemyBullet>().SetMoveDirection(bulDir);

        angle += 50f;
    }
    private void FirePattern3()
    {
        InvokeRepeating("FirePattern3Core", 0f, 0.1f);
        StartCoroutine(ChangeWait());
    }

    private void FirePattern4Core()
    {
        for (int i= 0; i<= 1; i++)
        {
            float bulDirX = transform.position.x + Mathf.Sin(((angle + 180f * i) * Mathf.PI) / 180f);
            float bulDirY = transform.position.y + Mathf.Cos(((angle + 180f * i) * Mathf.PI) / 180f);

            Vector3 bulMoveVector = new Vector3(bulDirX, bulDirY, 0f);
            Vector2 bulDir = (bulMoveVector - transform.position).normalized;

            GameObject bul = BulletPool.bulletPoolInstanse.GetBullet();
            bul.transform.position = transform.position;
            bul.transform.rotation = transform.rotation;
            bul.SetActive(true);
            bul.GetComponent<EnemyBullet>().SetMoveDirection(bulDir);
        }

        angle += 10f;

        if (angle >= 360f)
        {
            angle = 0f;
        }
    }
    private void FirePattern4()
    {
        InvokeRepeating("FirePattern4Core", 0f, 0.1f);
        StartCoroutine(ChangeWait());
    }

    IEnumerator ChangeWait()
    {
        hasAttacked = true;
        yield return new WaitForSeconds(5f);
        //int selectedPattern = Random.Range(0, 3);
        CancelInvoke();
        hasAttacked = false;
    }
}
