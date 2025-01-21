using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Standoff : MonoBehaviour
{
    public GameObject DisplayBox;
    public GameObject PassBox;
    public int QTEGen;
    public int waitingForKey = 1;
    public int correctKey;
    public int countingDown;

    private void Start()
    {
        StartCoroutine(WaitAtStart());
    }
    private void Update()
    {
        if (waitingForKey == 0)
        {
            QTEGen = Random.Range(1, 31);
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
            if (QTEGen == 4)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "W";
            }
            if (QTEGen == 5)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "Q";
            }
            if (QTEGen == 6)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "Y";
            }
            if (QTEGen == 7)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "U";
            }
            if (QTEGen == 8)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "I";
            }
            if (QTEGen == 9)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "O";
            }
            if (QTEGen == 10)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "P";
            }
            if (QTEGen == 11)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "A";
            }
            if (QTEGen == 12)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "S";
            }
            if (QTEGen == 13)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "D";
            }
            if (QTEGen == 14)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "F";
            }
            if (QTEGen == 15)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "G";
            }
            if (QTEGen == 16)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "H";
            }
            if (QTEGen == 17)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "J";
            }
            if (QTEGen == 18)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "K";
            }
            if (QTEGen == 19)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "L";
            }
            if (QTEGen == 20)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "Z";
            }
            if (QTEGen == 21)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "X";
            }
            if (QTEGen == 22)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "C";
            }
            if (QTEGen == 23)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "V";
            }
            if (QTEGen == 24)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "B";
            }
            if (QTEGen == 25)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "N";
            }
            if (QTEGen == 26)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "M";
            }
            if (QTEGen == 27)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "UP";
            }
            if (QTEGen == 28)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "DOWN";
            }
            if (QTEGen == 29)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "LEFT";
            }
            if (QTEGen == 30)
            {
                waitingForKey = 1;
                DisplayBox.GetComponent<Text>().text = "RIGHT";
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
        if (QTEGen == 4)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.W))
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
        if (QTEGen == 5)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.Q))
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
        if (QTEGen == 6)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.Y))
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
        if (QTEGen == 7)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.U))
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
        if (QTEGen == 8)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.I))
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
        if (QTEGen == 9)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.O))
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
        if (QTEGen == 10)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.P))
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
        if (QTEGen == 11)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.A))
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
        if (QTEGen == 12)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.S))
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
        if (QTEGen == 13)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.D))
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
        if (QTEGen == 14)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.F))
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
        if (QTEGen == 15)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.G))
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
        if (QTEGen == 16)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.H))
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
        if (QTEGen == 17)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.J))
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
        if (QTEGen == 18)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.K))
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
        if (QTEGen == 19)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.L))
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
        if (QTEGen == 20)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.Z))
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
        if (QTEGen == 21)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.X))
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
        if (QTEGen == 22)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.C))
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
        if (QTEGen == 23)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.V))
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
        if (QTEGen == 24)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.B))
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
        if (QTEGen == 25)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.N))
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
        if (QTEGen == 26)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.M))
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
        if (QTEGen == 27)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
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
        if (QTEGen == 28)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
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
        if (QTEGen == 29)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
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
        if (QTEGen == 30)
        {
            if (Input.anyKeyDown)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
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
        yield return new WaitForSeconds(3f);
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

    IEnumerator WaitAtStart()
    {
        yield return new WaitForSeconds(5f);
        waitingForKey = 0;
        QTEGen = 4;
    }
}