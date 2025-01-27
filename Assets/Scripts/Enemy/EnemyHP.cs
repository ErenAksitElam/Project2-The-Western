using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float enemyHP = 100;
    public Image bossBar;

    public float maxHealth;

    private void Update()
    {
        if (enemyHP < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            enemyHP -= 10;
            bossBar.fillAmount = enemyHP / maxHealth;
        }
    }
}
