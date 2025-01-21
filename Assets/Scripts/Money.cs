using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    static float money;
    private int firstTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (firstTime == 1)
        {
            money = 1;
            firstTime += 1;
        }
    }
}
