using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Family : MonoBehaviour
{
    public TMP_Text totalText;
    public TMP_Text remainingText;
    public TMP_Text livingExpensesText;
    public TMP_Text dayText;
    public TMP_Text foodText;
    public TMP_Text medicineText;

    public GameObject foodTextObject;
    public GameObject medicineTextObject;

    public Money moneyScript;
    private GameObject familyMoney;

    private bool foodCheck;
    private bool medicineCheck;

    private float remainingMoney;
    static float livingExpenses;

    static float selfHappiness = 100;
    static float wifeHappiness = 100;
    static float sonHappiness = 100;

    private float selfSicknessRNG;
    private float wifeSicknessRNG;
    private float sonSicknessRNG;

    public GameObject selfOK;
    public GameObject selfBAD;
    public GameObject selfSICK;
    public GameObject WifeOK;
    public GameObject WifeBAD;
    public GameObject WifeSICK;
    public GameObject SonOK;
    public GameObject SonBAD;
    public GameObject SonSICK;

    static int day;

    public int selfSickCounter;
    public int wifeSickCounter;
    public int sonSickCounter;

    public bool selfIsSick;
    public bool wifeIsSick;
    public bool sonIsSick;

    // Start is called before the first frame update
    void Start()
    {
        livingExpenses = 2f * day;
        remainingMoney = moneyScript.moneyPublic - livingExpenses;
        day += 1;

        selfSicknessRNG = Random.Range(1, 101);
        wifeSicknessRNG = Random.Range(1, 101);
        sonSicknessRNG = Random.Range(1, 101);
    }

    // Update is called once per frame+
    void Update()
    {
        totalText.SetText(moneyScript.moneyPublic.ToString() + "$");
        remainingText.SetText("Remaining:" + remainingMoney.ToString() + "$");
        livingExpensesText.SetText(livingExpenses.ToString() + "$");
        dayText.SetText("DAY: " + day.ToString());

        if (foodCheck)
        {
            foodTextObject.SetActive(true);
        }

        if (medicineCheck)
        {
            medicineTextObject.SetActive(true);
        }

        if (selfHappiness >= 90)
        {
            if (selfSicknessRNG == 1)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(true);
                selfBAD.SetActive(false);
                selfSICK.SetActive(false);
            }
        }
        else if (selfHappiness >= 75)
        {
            if (selfSicknessRNG <= 5)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(true);
                selfBAD.SetActive(false);
                selfSICK.SetActive(false);
            }
        }
        else if (selfHappiness >= 50)
        {
            if (selfSicknessRNG <= 15)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(true);
                selfSICK.SetActive(false);
            }
        }
        else if (selfHappiness >= 25)
        {
            if (selfSicknessRNG <= 30)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(true);
                selfSICK.SetActive(false);
            }
        }
        else if (selfHappiness <= 10)
        {
            if (selfSicknessRNG <= 45)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);
            }
        }

        if (wifeHappiness >= 90)
        {
            if (wifeSicknessRNG == 1)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
            }
            else
            {
                wifeOK.SetActive(true);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(false);
            }
        }
        else if (wifeHappiness >= 75)
        {
            if (wifeSicknessRNG <= 5)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
            }
            else
            {
                wifeOK.SetActive(true);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(false);
            }
        }
        else if (wifeHappiness >= 50)
        {
            if (wifeSicknessRNG <= 15)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(true);
                selfSICK.SetActive(false);
            }
        }
        else if (selfHappiness >= 25)
        {
            if (selfSicknessRNG <= 30)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(true);
                selfSICK.SetActive(false);
            }
        }
        else if (selfHappiness <= 10)
        {
            if (selfSicknessRNG <= 45)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
            }
            else
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);
            }
        }
    }

    public void FoodChecked()
    {
        foodCheck = true;
    }

    public void MedicineChecked()
    {
        medicineCheck = true;
    }
}