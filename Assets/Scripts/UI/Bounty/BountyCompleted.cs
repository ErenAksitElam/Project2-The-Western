using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BountyCompleted : MonoBehaviour
{
    public void BountyCompletedContinue()
    {
        SceneManager.LoadScene("FamilyCutscene");
    }
}
