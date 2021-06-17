using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Vector2 obstacleVelocity;
    Rigidbody2D obstacleRigidbody;
    void Awake()
    {
        obstacleRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        obstacleRigidbody.velocity = obstacleVelocity; 
    }
}
