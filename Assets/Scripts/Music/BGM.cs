using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    public GameObject BGMStart;
    public GameObject BGMLooping;

    private void Start()
    {
        StartCoroutine(BGMManager());
    }

    public IEnumerator BGMManager()
    {
        yield return new WaitForSeconds(81f);
        BGMLooping.SetActive(true);
        BGMStart.SetActive(false);
    }
}
