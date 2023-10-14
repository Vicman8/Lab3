using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public string scenename;
    public void PlayAgain()
    {
        SceneManager.LoadScene(scenename);
    }
}
