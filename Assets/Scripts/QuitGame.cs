using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    
    public void ExitGame()
    {
        Application.Quit();

        Debug.Log("Done playing");
    }
}