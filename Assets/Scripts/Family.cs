using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.ExceptionServices;

public class Family : MonoBehaviour
{
    public TMP_Text totalText;
    public TMP_Text remainingText;
    public TMP_Text livingExpensesText;
    public TMP_Text dayText;
    public TMP_Text foodText;
    public TMP_Text medicineText;
    public TMP_Text bountyRewardText;

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

    public static float totalMoney = 0;
    public static float remainingMoney = 0;
    static float livingExpenses = 0;

    static float selfHappiness = 75;
    static float wifeHappiness = 75;
    static float sonHappiness = 75;

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

    public static float day = 0;

    static int selfSickCounter = 0;
    static int wifeSickCounter = 0;
    static int sonSickCounter = 0;

    static bool selfIsSick = false;
    static bool wifeIsSick = false;
    static bool sonIsSick = false;

    public static float bountyReward = 0;

    private int deathScreenRNG;

    // Start is called before the first frame update
    void Start()
    {
        //remainingMoney = moneyScript.moneyPublic - livingExpenses;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "FamilyMenu")
        {
            day += 0.5f;
        }
        livingExpenses = day;
        selfSicknessRNG = Random.Range(1, 101);
        wifeSicknessRNG = Random.Range(1, 101);
        sonSicknessRNG = Random.Range(1, 101);

        deathScreenRNG = Random.Range(1, 7);

        totalMoney = remainingMoney + bountyReward;
    }

    // Update is called once per frame+
    void Update()
    {
        totalText.SetText(totalMoney.ToString() + "$");
        remainingText.SetText("Remaining:" + remainingMoney.ToString() + "$");
        livingExpensesText.SetText(livingExpenses.ToString() + "$");
        dayText.SetText("DAY: " + day.ToString());
        bountyRewardText.SetText(bountyReward + "$");

        remainingMoney = totalMoney - livingExpenses - foodCostCurrent - medicineCostCurrent;

        if (selfHappiness >= 90)
        {
            if (selfSicknessRNG == 10)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
                selfIsSick = true;
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
            if (selfSicknessRNG <= 20)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
                selfIsSick = true;
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
            if (selfSicknessRNG <= 30)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
                selfIsSick = true;
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
            if (selfSicknessRNG <= 75)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
                selfIsSick = true;
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
            if (selfSicknessRNG <= 90)
            {
                selfOK.SetActive(false);
                selfBAD.SetActive(false);
                selfSICK.SetActive(true);

                selfSickCounter += 1;
                selfIsSick = true;
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
            if (wifeSicknessRNG <= 10)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
                wifeIsSick = true;
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
            if (wifeSicknessRNG <= 20)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
                wifeIsSick = true;
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
            if (wifeSicknessRNG <= 30)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
                wifeIsSick = true;
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
            if (wifeSicknessRNG <= 75)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
                wifeIsSick = true;
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
            if (wifeSicknessRNG <= 90)
            {
                wifeOK.SetActive(false);
                wifeBAD.SetActive(false);
                wifeSICK.SetActive(true);

                wifeSickCounter += 1;
                wifeIsSick = true;
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
            if (sonSicknessRNG == 10)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
                sonIsSick = true;
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
            if (sonSicknessRNG <= 20)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
                sonIsSick = true;
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
            if (sonSicknessRNG <= 30)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
                sonIsSick = true;
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
            if (sonSicknessRNG <= 75)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
                sonIsSick = true;
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
            if (sonSicknessRNG <= 90)
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonSickCounter += 1;
                sonIsSick = true;
            }
            else
            {
                sonOK.SetActive(false);
                sonBAD.SetActive(false);
                sonSICK.SetActive(true);

                sonIsSick = true;
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
        if (foodCheck)
        {
            selfHappiness += 10;
            wifeHappiness += 10;
            sonHappiness += 10;
        }
        else if (!foodCheck)
        {
            selfHappiness -= 10;
            wifeHappiness -= 10;
            sonHappiness -= 10;
        }

        if (selfIsSick && medicineCheck)
        {
            selfHappiness += 10;
            selfIsSick = false;
            selfOK.SetActive(true);
            selfBAD.SetActive(false);
            selfSICK.SetActive(false);
            SceneManager.LoadScene("BountyCutscene");
        }
        else if (selfIsSick && !medicineCheck)
        {
            if (deathScreenRNG == 1)
            {
                SceneManager.LoadScene("YouDiedCholera");
            }
            else if (deathScreenRNG == 2)
            {
                SceneManager.LoadScene("YouDiedDysentery");
            }
            else if (deathScreenRNG == 3)
            {
                SceneManager.LoadScene("YouDiedMountainFever");
            }
            else if (deathScreenRNG == 4)
            {
                SceneManager.LoadScene("YouDiedScurvy");
            }
            else if (deathScreenRNG == 5)
            {
                SceneManager.LoadScene("YouDiedSmallpox");
            }
            else if (deathScreenRNG == 6)
            {
                SceneManager.LoadScene("YouDiedTuberculosis");
            }
            else
            {
                SceneManager.LoadScene("YouDiedTuberculosis");
            }
        }
        else if (wifeIsSick && medicineCheck)
        {
            wifeHappiness += 10;
            wifeIsSick = false;
            wifeOK.SetActive(true);
            wifeBAD.SetActive(false);
            wifeSICK.SetActive(false);
            SceneManager.LoadScene("BountyCutscene");
        }
        else if (wifeIsSick && !medicineCheck)
        {
            if (deathScreenRNG == 1)
            {
                SceneManager.LoadScene("WifeDiedCholera");
            }
            else if (deathScreenRNG == 2)
            {
                SceneManager.LoadScene("WifeDiedDysentery");
            }
            else if (deathScreenRNG == 3)
            {
                SceneManager.LoadScene("WifeDiedMountainFever");
            }
            else if (deathScreenRNG == 4)
            {
                SceneManager.LoadScene("WifeDiedScurvy");
            }
            else if (deathScreenRNG == 5)
            {
                SceneManager.LoadScene("WifeDiedSmallpox");
            }
            else if (deathScreenRNG == 6)
            {
                SceneManager.LoadScene("WifeDiedTuberculosis");
            }
            else
            {
                SceneManager.LoadScene("YouDiedTuberculosis");
            }
        }
        else if (sonIsSick && medicineCheck)
        {
            sonHappiness += 10;
            sonIsSick = false;
            sonOK.SetActive(true);
            sonBAD.SetActive(false);
            sonSICK.SetActive(false);
            SceneManager.LoadScene("BountyCutscene");
        }
        else if (sonIsSick && !medicineCheck)
        {
            if (deathScreenRNG == 1)
            {
                SceneManager.LoadScene("SonDiedCholera");
            }
            else if (deathScreenRNG == 2)
            {
                SceneManager.LoadScene("SonDiedDysentery");
            }
            else if (deathScreenRNG == 3)
            {
                SceneManager.LoadScene("SonDiedMountainFever");
            }
            else if (deathScreenRNG == 4)
            {
                SceneManager.LoadScene("SonDiedScurvy");
            }
            else if (deathScreenRNG == 5)
            {
                SceneManager.LoadScene("SonDiedSmallpox");
            }
            else if (deathScreenRNG == 6)
            {
                SceneManager.LoadScene("SonDiedTuberculosis");
            }
            else
            {
                SceneManager.LoadScene("YouDiedTuberculosis");
            }
        }
        else if (!selfIsSick)
        {
            SceneManager.LoadScene("BountyCutscene");
        }
        else if (!wifeIsSick)
        {
            SceneManager.LoadScene("BountyCutscene");
        }
        else if (!sonIsSick)
        {
            SceneManager.LoadScene("BountyCutscene");
        }
    }

    public void OneStarBounty()
    {
        bountyReward = 3;
    }
    public void TwoStarBounty()
    {
        bountyReward = 5;
    }
    public void ThreeStarBounty()
    {
        bountyReward = 7;
    }
    public void FourStarBounty()
    {
        bountyReward = 10;
    }


    public void Clear()
    {
        day = 0;
        totalMoney = 0;
        remainingMoney = 0;
    }
}