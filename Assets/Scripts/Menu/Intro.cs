using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("MainMenu");
    }
}