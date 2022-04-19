using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public int index;
    public string levelName;

    bool p1plat = false;
    bool p2plat = false;

    void OnTriggerStay2D(Collider2D Other)
    {
        if (Other.CompareTag("Player1"))
            p1plat = true;
        if (Other.CompareTag("Player2"))
            p2plat = true;
        if (p1plat == true && p2plat == true)
        {
            SceneManager.LoadScene(index);
            SceneManager.LoadScene("Level2");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        p1plat = false;
        p2plat = false;
    }
}