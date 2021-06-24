using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public bool standing;
    Rigidbody2D rb;
    public bool actionButton;
    public float absValX, absValY;
    public float standingSpeed = 1;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        actionButton = Input.anyKeyDown;
    }
    private void FixedUpdate()
    {
        absValX = System.Math.Abs(rb.velocity.x);
        absValY = System.Math.Abs(rb.velocity.y);

        standing = absValY <= standingSpeed;

    }
}
