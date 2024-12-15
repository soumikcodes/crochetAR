using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{
    public void QuitGame()
    {
        // Logs a message in the editor for testing
        Debug.Log("Quit button clicked!");

        // Quit the application
        Application.Quit();
    }
}

