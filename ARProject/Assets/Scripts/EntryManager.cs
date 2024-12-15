using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntryManager : MonoBehaviour
{
    public GameObject entryCanvas;
    public GameObject exitCanvas;

    public void StartApp()
    {
        if (entryCanvas != null)
        {
            exitCanvas.SetActive(true);
            entryCanvas.SetActive(false);
        }

        // If you want to load another scene, uncomment this:
        // SceneManager.LoadScene("YourARSceneName");
    }
}
