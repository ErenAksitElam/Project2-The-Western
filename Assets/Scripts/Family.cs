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

    private float foodCost = 0;
    private float medicineCost = 0;

    private float foodCostCurrent = 0;
    private float medicineCostCurrent = 0;

    static float totalMoney = 0;
    static float remainingMoney = 5;
    static float livingExpenses = 0;

    static float selfHappiness = 100;
    static float wifeHappiness = 100;
    static float sonHappiness = 100;

    private float selfSicknessRNG;
    private float wifeSicknessRNG;
    private float sonSicknessRNG;

    public GameObject selfOK;
    public GameObject selfBAD;
    public GameObject selfSICK;
    public GameObject wifeOK;
    public GameObject wifeBAD;
    public GameObject wifeSICK;
    public GameObject sonOK;
    public GameObject sonBAD;
    public GameObject sonSICK;

    public static int day = -1;

    static int selfSickCounter = 0;
    static int wifeSickCounter = 0;
    static int sonSickCounter = 0;

    static bool selfIsSick = false;
    static bool wifeIsSick = false;
    static bool sonIsSick = false;

    public float bountyReward;

    // Start is called before the first frame update
    void Start()
    {
        livingExpenses = 2f * day;
        //remainingMoney = moneyScript.moneyPublic - livingExpenses;
        day += 1;

        selfSicknessRNG = Random.Range(1, 101);
        wifeSicknessRNG = Random.Range(1, 101);
        sonSicknessRNG = Random.Range(1, 101);

        totalMoney = remainingMoney;
    }

    // Update is called once per frame+
    void Update()
    {
        totalText.SetText(totalMoney.ToString() + "$");
        remainingText.SetText("Remaining:" + remainingMoney.ToString() + "$");
        livingExpensesText.SetText(livingExpenses.ToString() + "$");
        dayText.SetText("DAY: " + day.ToString());

        remainingMoney = totalMoney - livingExpenses - foodCostCurrent - medicineCostCurrent + bountyReward;

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
                wifeOK.SetActive(false);
                wifeBAD.SetActive(true);
                wifeSICK.SetActive(false);
            }
        }
        else if (wifeHappiness >= 25)
        {
            if (wifeSicknessRNG <= 30)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
            }
            else
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(true);
                wifeSICK.SetActive(false);
            }
        }
        else if (wifeHappiness <= 10)
        {
            if (wifeSicknessRNG <= 45)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
            }
            else
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);
            }
        }

        if (sonHappiness >= 90)
        {
            if (sonSicknessRNG == 1)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
            }
            else
            {
                sonOK.SetActive(true);
                sonBAD.SetActive(false);
                sonSICK.SetActive(false);
            }
        }
        else if (sonHappiness >= 75)
        {
            if (sonSicknessRNG <= 5)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
            }
            else
            {
                sonOK.SetActive(true);
                sonBAD.SetActive(false);
                sonSICK.SetActive(false);
            }
        }
        else if (sonHappiness >= 50)
        {
            if (sonSicknessRNG <= 15)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
            }
            else
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(true);
                sonSICK.SetActive(false);
            }
        }
        else if (sonHappiness >= 25)
        {
            if (sonSicknessRNG <= 30)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
            }
            else
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(true);
                sonSICK.SetActive(false);
            }
        }
        else if (sonHappiness <= 10)
        {
            if (sonSicknessRNG <= 45)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
            }
            else
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);
            }
        }

        medicineCostCurrent = medicineCost;
        foodCostCurrent = foodCost;
    }

    public void FoodChecked(bool foodTickOn)
    {
        if (foodTickOn)
        {
            foodTextObject.SetActive(true);
            foodCost += day;
            foodText.SetText("-" + foodCost.ToString() + "$");
            foodCheck = true;
        }
        else
        {
            foodTextObject.SetActive(false);
            foodCost -= day;
            foodCheck = false;
        }
    }

    public void MedicineChecked(bool medicineTickOn)
    {
        if (medicineTickOn)
        {
            medicineTextObject.SetActive(true);
            medicineCost += day;
            medicineText.SetText("-" + medicineCost.ToString() + "$");
            medicineCheck = true;
        }
        else
        {
            medicineTextObject.SetActive(false);
            medicineCost -= day;
            medicineCheck = false;
        }
    }

    public void NextBounty()
    {

    }
}