using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript2 : MonoBehaviour
{
    public bool button2Pressed = false;
    public GameObject button2;

    public Sprite buttonUp;
    public Sprite buttonDown;

    void OnTriggerStay2D(Collider2D Other)
    {
        // Changes button sprite when player steps on the button
        button2.GetComponent<SpriteRenderer>().sprite = buttonDown;

        if (Other.CompareTag("Player1") || Other.CompareTag("Player2"))
            button2Pressed = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        // Changes button sprite when player steps off the button
        button2.GetComponent<SpriteRenderer>().sprite = buttonUp;

        button2Pressed = false;
    }
}