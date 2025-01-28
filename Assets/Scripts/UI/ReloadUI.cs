using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadUI : MonoBehaviour
{
    public PlayerMovement PlayerMovementScript;

    Animator reloadAnim;
    // Start is called before the first frame update
    void Start()
    {
        reloadAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerMovementScript.isReloading)
        {
            reloadAnim.SetBool("isReloading", true);
        }
        else
        {
            reloadAnim.SetBool("isReloading", false);
        }
    }
}
