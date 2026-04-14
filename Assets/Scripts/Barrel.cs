using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "PlayerBullet")
        {
            other.gameObject.SetActive(false);
        }
    }
}
