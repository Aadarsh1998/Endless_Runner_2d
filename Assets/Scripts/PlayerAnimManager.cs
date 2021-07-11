using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimManager : MonoBehaviour
{
    private Animator animator;
    private PlayerState playerState;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerState = GetComponent<PlayerState>();
    }
    private void Update()
    {
        var running = true;
        if(playerState.absValX > 0 && playerState.absValY < playerState.standingSpeed)
        {
            running = false;
        }
        animator.SetBool("Running",running);
    }
}
