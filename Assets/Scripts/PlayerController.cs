using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float hMovement = 10.0f;
    public float vMovement = 16.0f;
    public float movementSpeed = 10.0f;

    private Rigidbody2D playerRB;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckInput();
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    private void CheckInput()
    {
        hMovement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, vMovement);
        }
    }

    private void ApplyMovement()
    {
        playerRB.velocity = new Vector2(movementSpeed * hMovement, playerRB.velocity.y);
    }
}