using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Standoff2 : MonoBehaviour
{
    public bool standoff = false;

    public GameObject Pass;
    public GameObject Fail;
    public GameObject[] Patterns;
    public GameObject BulletText;
    public GameObject HPText;
    public PlayerMovement playerMovementScript;
    public EnemyFireBullets enemyFireBulletsScript;
    public AIPath aiPathScript;
    public AIDestinationSetter aiDestinationSetterScript;

    public GameObject Enemy;

    public GameObject[] Checks;

    private List<KeyCode> buttonSequence1 = new List<KeyCode> { KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.UpArrow };
    private List<KeyCode> buttonSequence2 = new List<KeyCode> { KeyCode.UpArrow, KeyCode.E, KeyCode.UpArrow, KeyCode.E, KeyCode.UpArrow };
    private int currentIndex = 0;

    public bool Passing;
    public bool Failing;

    public int gen;
    private Rigidbody2D EnemyRB;

    public int buffSelect;

    public GameObject BuffText1;
    public GameObject BuffText2;
    public TMP_Text BuffText1TMP;
    public TMP_Text BuffText2TMP;

    public GameObject HealthBar1;

    // Start is called before the first frame update
    void Start()
    {
        standoff = true;
        currentIndex = 0; // Reset sequence on new standoff.
        gen = Random.Range(1, 3);
        buffSelect = Random.Range(1, 3);
        EnemyRB = Enemy.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!standoff)
        {
            ResetUI();
            EnemyRB.simulated = true;
            return;
        }

        if (standoff)
        {
            EnemyRB.simulated = false;
        }

        BulletText.SetActive(false);
        HPText.SetActive(false);

        if (gen == 1)
        {
            Patterns[0].SetActive(true); // Display pattern indicator.

            // Check for player input only during the standoff.
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(buttonSequence1[currentIndex]))
                {
                    Checks[currentIndex].SetActive(true);
                    currentIndex++;
                    if (currentIndex >= buttonSequence1.Count)
                    {
                        StartCoroutine(Passed());
                    }
                }
                else
                {
                    StartCoroutine(Failed());
                }
            }
        }
        else if (gen == 2)
        {
            Patterns[1].SetActive(true);

            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(buttonSequence2[currentIndex]))
                {
                    Checks[currentIndex].SetActive(true);
                    currentIndex++;
                    if (currentIndex >= buttonSequence2.Count)
                    {
                        StartCoroutine(Passed());
                    }
                }
                else
                {
                    StartCoroutine(Failed());
                }
            }
        }

    }

    void ResetUI()
    {
        BulletText.SetActive(true);
        HPText.SetActive(true);

        foreach (var pattern in Patterns)
        {
            pattern.SetActive(false);
        }

        Pass.SetActive(false);
        Fail.SetActive(false);

        playerMovementScript.gameObject.SetActive(true);
        enemyFireBulletsScript.gameObject.SetActive(true);
        aiPathScript.gameObject.SetActive(true);
        aiDestinationSetterScript.gameObject.SetActive(true);

        for (int i = 0; i < Checks.Length; i++)
        {
            Checks[i].SetActive(false);
        }

        BuffText1.SetActive(false);
        BuffText2.SetActive(false);

        HealthBar1.SetActive(true);
    }

    IEnumerator WaitAtStart()
    {
        yield return new WaitForSeconds(0.5f);
        standoff = true;
        currentIndex = 0; // Reset sequence on new standoff.
    }

    IEnumerator Passed()
    {
        Passing = true;
        Pass.SetActive(true);

        if (buffSelect == 1)
        {
            Buff1();
        }
        else if (buffSelect == 2)
        {
            Buff2();
        }

        yield return new WaitForSeconds(1.5f);
        standoff = false;
    }

    IEnumerator Failed()
    {
        Failing = true;
        Fail.SetActive(true);
        if (buffSelect == 1)
        {
            Debuff1();
        }
        else if (buffSelect == 2)
        {
            Debuff2();
        }
        yield return new WaitForSeconds(1.5f);
        standoff = false;
    }

    public void Buff1()
    {
        playerMovementScript.movementSpeed *= 1.2f;
        playerMovementScript.dashCooldown *= 0.8f;

        BuffText1.SetActive(true);
        BuffText2.SetActive(true);

        BuffText1TMP.SetText("+20% Movement Speed");
        BuffText2TMP.SetText("-20% Dash Cooldown");
        return;
    }

    public void Buff2()
    {
        playerMovementScript.bulletSpeed *= 1.1f;
        playerMovementScript.dashSpeed *= 1.15f;

        BuffText1.SetActive(true);
        BuffText2.SetActive(true);

        BuffText1TMP.SetText("+10% Movement Speed");
        BuffText2TMP.SetText("+15% Dash Speed");
        return;
    }

    public void Debuff1()
    {
        playerMovementScript.movementSpeed *= 0.8f;
        playerMovementScript.dashCooldown *= 1.2f;

        BuffText1.SetActive(true);
        BuffText2.SetActive(true);

        BuffText1TMP.SetText("-20% Movement Speed");
        BuffText2TMP.SetText("+20% Dash Cooldown");
        return;
    }
    public void Debuff2()
    {
        playerMovementScript.bulletSpeed *= 0.9f;
        playerMovementScript.dashSpeed *= 0.95f;

        BuffText1.SetActive(true);
        BuffText2.SetActive(true);

        BuffText1TMP.SetText("-10% Bullet Speed");
        BuffText2TMP.SetText("-5% Dash Speed");
        return;
    }
}