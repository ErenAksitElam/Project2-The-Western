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

    private void Start()
    {
        selectedPattern = Random.Range(1, 2);
    }

    private void Update()
    {
        if (selectedPattern == 1 && hasAttacked == false)
        {
            InvokeRepeating("FirePattern1", 0f, 2f);
            StartCoroutine(ChangeWait());
        }
        if (selectedPattern == 2 && hasAttacked == false)
        {
            InvokeRepeating("FirePattern2", 0f, 0.1f);
            StartCoroutine(ChangeWait());
        }
    }

    private void FirePattern1()
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
    private void FirePattern2()
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

    IEnumerator ChangeWait()
    {
        hasAttacked = true;
        yield return new WaitForSeconds(3.5f);
        selectedPattern = Random.Range(1, 2);
    }
}
