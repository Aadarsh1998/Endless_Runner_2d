using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerState playerState;
    public float jumpSpeed;
    public float forwardSpeed;
    private Animator animator;
    private PlayerAnimManager animManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerState = GetComponent<PlayerState>();
        animator = GetComponent<Animator>();
        animManager = GetComponent<PlayerAnimManager>();
    }
    void Start()
    {

    }


    void Update()
    {
        if (playerState.standing)
        {
            var jumping = true;
            if (playerState.actionButton)
            {
                
                rb.velocity = new Vector2(transform.position.x < 0 ? forwardSpeed : 0, jumpSpeed);
                //jumping = true;
                animator.SetBool("Jump", jumping);
            }
            
        }
    }
}
