using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BountyMenu : MonoBehaviour
{
    public GameObject BountyPoster1;
    public GameObject BountyPoster2;
    public GameObject BountyPoster3;
    public GameObject BountyPoster4;

    public int randomLevel;
    // Start is called before the first frame update
    void Start()
    {
        randomLevel = Random.Range(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Poster1()
    {
        if (randomLevel == 1)
        {
            SceneManager.LoadScene("TutorialVeryEasy1");
        }
    }
    public void Poster2()
    {
        if (randomLevel == 1)
        {
            SceneManager.LoadScene("TutorialEasy1");
        }
    }
    public void Poster3()
    {
        if (randomLevel == 1)
        {
            SceneManager.LoadScene("TutorialHard1");
        }
    }
    public void Poster4()
    {
        if (randomLevel == 1)
        {
            SceneManager.LoadScene("TutorialVeryHard1");
        }
    }
}
