using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Family : MonoBehaviour
{
    public TMP_Text totalText;
    public Money moneyScript;
    private GameObject familyMoney;

    private bool FoodCheck;
    private bool MedicineCheck;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalText.SetText(moneyScript.moneyPublic.ToString() + "$");

        Debug.Log("")
    }

    public void FoodChecked()
    {
        FoodCheck = true;
    }

    public void MedicineChecked()
    {
        MedicineCheck = true;
    }
}
