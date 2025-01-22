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
    private float livingExpenses;

    static int day;

    // Start is called before the first frame update
    void Start()
    {
        livingExpenses = 2f * day;
        remainingMoney = moneyScript.moneyPublic - livingExpenses;
        day += 1;
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
