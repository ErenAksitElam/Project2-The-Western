using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaloonCutscene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("BountyMenu");
    }
}
