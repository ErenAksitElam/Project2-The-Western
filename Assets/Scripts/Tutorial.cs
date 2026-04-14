using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public void TutorialContinue()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (sceneName == "TutorialVeryEasy1")
        {
            SceneManager.LoadScene("VeryEasyLevel1");
        }
        else if (sceneName == "TutorialEasy1")
        {
            SceneManager.LoadScene("EasyLevel1");
        }
        else if (sceneName == "TutorialHard1")
        {
            SceneManager.LoadScene("HardLevel1");
        }
        else if (sceneName == "TutorialVeryHard1")
        {
            SceneManager.LoadScene("VeryHardLevel1");
        }
    }
}
