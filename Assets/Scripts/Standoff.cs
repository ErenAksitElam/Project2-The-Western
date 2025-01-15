using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Standoff : MonoBehaviour
{

    public GameObject DisplayBox;
    public GameObject PassBox;
    public int QTEGen;
    public int waitingForKey;
    public int correctKey;
    public int countingDown;

    private void Update()
    {
        if (waitingForKey == 0)
        {
            QTEGen = Random.Range(1, 4);
            countingDown = 1;
            StartCoroutine(CountDown());
            if(QTEGen == 1)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "E";
            }
            if (QTEGen == 2)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "R";
            }
            if (QTEGen == 3)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "T";
            }
        }

        if (QTEGen == 1)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    correctKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    correctKey = 2;
                    StartCoroutine (KeyPressing ());
                }
            }
        }

        if (QTEGen == 2)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    correctKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    correctKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }

        if (QTEGen == 3)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.T))
                {
                    correctKey = 1;
                    StartCoroutine(KeyPressing());
                }
                else
                {
                    correctKey = 2;
                    StartCoroutine(KeyPressing());
                }
            }
        }
    }

    IEnumerator KeyPressing()
    {
        QTEGen = 4;
        if (correctKey == 1)
        {
            countingDown = 2;
            PassBox.GetComponent<Text>().text = "PASS!";
            yield return new WaitForSeconds(1.5f);
            correctKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            waitingForKey = 0;
            countingDown = 1;
        }
        if (correctKey == 2)
        {
            countingDown = 2;
            PassBox.GetComponent<Text>().text = "FAIL!";
            yield return new WaitForSeconds(1.5f);
            correctKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            waitingForKey = 0;
            countingDown = 1;
        }
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(3.5f);
        if (countingDown == 1)
        {
            QTEGen = 4;
            countingDown = 2;
            PassBox.GetComponent<Text>().text = "FAIL!";
            yield return new WaitForSeconds(1.5f);
            correctKey = 0;
            PassBox.GetComponent<Text>().text = "";
            DisplayBox.GetComponent<Text>().text = "";
            yield return new WaitForSeconds(1.5f);
            waitingForKey = 0;
            countingDown = 1;
        }
    }
}
