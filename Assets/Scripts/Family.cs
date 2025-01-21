using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Family : MonoBehaviour
{
    public TMP_Text totalText;
    public GameObject moneyScript;
    private GameObject familyMoney;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalText.SetText(.ToString());
    }
}
