using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float hMovement = 10.0f;
    public float vMovement = 12.0f;
    public float movementSpeed = 10.0f;

    private Rigidbody2D playerRB;

    //These are for checking if the player is touching the ground
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    public LayerMask player2Layer;
    private bool isTouchingGround;

    public beeTransition beeSequence;
    public cloudTransition cloudSequence;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (beeSequence.restrictMovement == false && cloudSequence.restrictMovement == false)
        {
            CheckInput();

            //checks if the player is touching the ground/platforms or player 2
            if (Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer) == true | Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, player2Layer) == true)
                isTouchingGround = true;
            else
                isTouchingGround = false;

            // isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        }
    }

    private void FixedUpdate()
    {
        if (beeSequence.restrictMovement == false && cloudSequence.restrictMovement == false)
            ApplyMovement();
    }

    private void CheckInput()
    {
        hMovement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && isTouchingGround == true)
            playerRB.velocity = new Vector2(playerRB.velocity.x, vMovement);
    }

    private void ApplyMovement()
    {
        playerRB.velocity = new Vector2(movementSpeed * hMovement, playerRB.velocity.y);
    }
}