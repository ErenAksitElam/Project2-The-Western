using JetBrains.Annotations;
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
    public GameObject Player;
    public GameObject Enemy;

    public int gen;
    public bool waitingForKey = true;

    public bool button1;
    public bool button2;
    public bool button3;
    public bool button4;
    public bool button5;

    public bool passed;
    public bool failed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAtStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (standoff == true)
        {
            BulletText.SetActive(false);
            HPText.SetActive(false);
        }
        if (standoff == false)
        {
            BulletText.SetActive(true);
            HPText.SetActive(true);

            Patterns[0].SetActive(false);
            Patterns[1].SetActive(false);

            Pass.SetActive(false);
            Fail.SetActive(false);
        }

        if(waitingForKey == false && standoff == true)
        {
            gen = Random.Range(1, 2);
        }

        if(gen == 1)
        {
            Patterns[0].SetActive(true);
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    button1 = true;
                    if (Input.GetKeyDown(KeyCode.DownArrow))
                    {
                        button2 = true;
                        if (Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            button3 = true;
                            if (Input.GetKeyDown(KeyCode.DownArrow))
                            {
                                button4 = true;
                                if (Input.GetKeyDown(KeyCode.UpArrow))
                                {
                                    button5 = true;
                                }
                                else
                                {
                                    StartCoroutine(Failed());
                                }
                            }
                            else
                            {
                                StartCoroutine(Failed());
                            }
                        }
                        else
                        {
                            StartCoroutine(Failed());
                        }
                    }
                    else
                    {
                        StartCoroutine(Failed());
                    }
                }
                else
                {
                    StartCoroutine(Failed());
                }
            }
        }
        if(gen == 2)
        {
            Patterns[1].SetActive(true);
        }

        if(button1 == true && button2 == true && button3 == true && button4 == true && button5 == true)
        {
            Pass.SetActive(true);
            StartCoroutine(Passed());

        }
    }

    IEnumerator WaitAtStart()
    {
        yield return new WaitForSeconds(3f);
        standoff = true;
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
