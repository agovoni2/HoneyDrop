using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    
   public GameObject Platform;

    int buttonPressed = 0;
    private GameObject player1;
    private GameObject player2;

    //public GameObject button2Script;
    public ButtonScript2 button2script;

   

    void OnTriggerEnter2D(Collider2D Other)
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        Debug.Log(button2script.button2Pressed);

        Debug.Log(player1.transform.position);

        if (Other.CompareTag("Player") || Other.CompareTag("Player2"))
        {
            if (button2script.button2Pressed)
            {
               Platform.SetActive(false);
            }
             
        }
    }
}