using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject Platform;
    public GameObject button1;
    public GameObject taxiBee;

    public Sprite buttonUp;
    public Sprite buttonDown;

    public int beeSpeed = 5;
    public int beeDistance = 5;
    int i = 0;

    bool callBee = false;
    bool beeCalled = false;

    //public GameObject button2Script;
    public ButtonScript2 button2script;


    private void Update()
    {
        if (callBee == true && beeCalled == false)
        {
            Debug.Log("The bee is on the way");
            beeCalled = true;
            StartCoroutine("MoveTaxiBee");
        }
    }

    IEnumerator MoveTaxiBee()
    {
        for (i = 0; i < 6; i++)
        {
            taxiBee.transform.position += transform.right * beeSpeed * beeDistance * Time.deltaTime;
            taxiBee.transform.position += -transform.up * beeSpeed * beeDistance * Time.deltaTime;
            yield return new WaitForSeconds(0.05f);
        }
    }


    void OnTriggerStay2D(Collider2D Other)
    {
        // Changes button sprite when player steps on the button
        button1.GetComponent<SpriteRenderer>().sprite = buttonDown;

        if (SceneManager.GetActiveScene().name == "level-2_baseOfTree")
        {
            if (Other.CompareTag("Player1") || Other.CompareTag("Player2"))
            {
                // If one player is standing on the button1, a platform disappears, allowing another player to get to button2
                Platform.SetActive(false);
  /////////              Debug.Log("Level 2 - State shift");

                if (button2script.button2Pressed)
                {
                    // In level 2, if both players stand on the buttons, the Taxi Bee drifts to the players
  /////////                  Debug.Log("Calling Taxi Bee...");
                    callBee = true;
                }
            }
        }
        else if (SceneManager.GetActiveScene().name == "level-1_cave")
        {
            if (Other.CompareTag("Player1") || Other.CompareTag("Player2"))
            {
                if (button2script.button2Pressed)
                {
                    // In level 1, if both players stand on the buttons, the Platform disappears
                    Platform.SetActive(false);
                    Debug.Log("Level 1 - Entrance Clear");
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Changes button sprite when player steps off the button
        button1.GetComponent<SpriteRenderer>().sprite = buttonUp;

        // In level 2, the platform reappears when the player isn't standing on the button
        if (SceneManager.GetActiveScene().name == "level-2_baseOfTree")
            Platform.SetActive(true);
    }
}