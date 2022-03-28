using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    public int index;
    public string levelName;
    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);

            SceneManager.LoadScene("Level2");
        }
    }
}
