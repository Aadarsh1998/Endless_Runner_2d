using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
    float screenResolution = 0;
    Rigidbody2D obstacleRb;
    float offset = 10.0f;
    bool obstacleBoundary;

    private void Awake()
    {
        obstacleRb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        screenResolution = ((Screen.width / PixelPerfectCamera.pixelToUnit) / 2) + offset;
    }

    private void Update()
    {
        var posX = transform.position.x;
        var direction = obstacleRb.velocity.x;

        if(Mathf.Abs(posX) > screenResolution)
        {
            if (posX < 0 && direction < screenResolution)
            {
                obstacleBoundary = true;
            }
            else if (posX > 0 && direction > -screenResolution)
            {
                obstacleBoundary = true;
            }
        }
        else
        {
            obstacleBoundary = false;
        }
        
        
        if(obstacleBoundary)
        {
            DestrObst();
            
        }
    }

    private void DestrObst()
    {
        Destroy(gameObject);
    }
}
