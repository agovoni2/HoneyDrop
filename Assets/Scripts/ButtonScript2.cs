using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript2 : MonoBehaviour
{
    public bool button2Pressed = false;
    private GameObject player1;
    private GameObject player2;

    private void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        if (Other.CompareTag("Player"))
        {
            button2Pressed = true;
        }
        else button2Pressed = false;
    }
}
