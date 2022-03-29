using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    [SerializeField]
    GameObject Platform;

    int buttonPressed = 0;
    private GameObject player1;
    private GameObject player2;

    private GameObject button2Script;
    private ButtonScript2 button2Pressed;

    private void Start()
    {
        button2Pressed = button2Script.GetComponent<ButtonScript2>();
    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        Debug.Log(button2Pressed.button2Pressed);

        Debug.Log(player1.transform.position);

        if (Other.CompareTag("Player"))
        {

        }
    }
}