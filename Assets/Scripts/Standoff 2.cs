using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private List<KeyCode> buttonSequence1 = new List<KeyCode> { KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.UpArrow };
    private List<KeyCode> buttonSequence2 = new List<KeyCode> { KeyCode.UpArrow, KeyCode.E, KeyCode.UpArrow, KeyCode.E, KeyCode.UpArrow };
    private int currentIndex = 0;


    public int gen;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAtStart());
        gen = Random.Range(1, 3);
    }

    // Update is called once per frame
    void Update()
    {

        if (!standoff)
        {
            ResetUI();
            return;
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
    }

    IEnumerator WaitAtStart()
    {
        yield return new WaitForSeconds(3f);
        standoff = true;
        currentIndex = 0; // Reset sequence on new standoff.
    }

    IEnumerator Passed()
    {
        Pass.SetActive(true);
        yield return new WaitForSeconds(5f);
        standoff = false;
    }

    IEnumerator Failed()
    {
        Fail.SetActive(true);
        yield return new WaitForSeconds(5f);
        standoff = false;
    }
}
