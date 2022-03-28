using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    void Update()
    {
        // Checks to see if the player Starts the game or Quits the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Escape pressed");
            Application.Quit();
        }
        else if (Input.anyKeyDown)
        {
            Debug.Log("Switching scene...");
            SceneManager.LoadScene("level-1_cave");
        }
    }
}