using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float hMovement = 10.0f;
    public float vMovement = 16.0f;
    public float movementSpeed = 10.0f;

    private Rigidbody2D playerRB;

    //These are for checking if the player is touching the ground
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckInput();

        //checks if the player is touching the ground/platforms
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    private void CheckInput()
    {
        hMovement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isTouchingGround == true)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, vMovement);
        }
    }

    private void ApplyMovement()
    {
        playerRB.velocity = new Vector2(movementSpeed * hMovement, playerRB.velocity.y);
    }
}