using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundingBox2 : MonoBehaviour
{
    private GameObject player1;
    private GameObject player2;

    void OnTriggerEnter2D(Collider2D Other)
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        if (Other.CompareTag("Player1"))
        {
            player1.transform.position = new Vector2(-8, 0);
        }

        if (Other.CompareTag("Player2"))
        {
            player2.transform.position = new Vector2(-8, 0);
        }
    }
}
