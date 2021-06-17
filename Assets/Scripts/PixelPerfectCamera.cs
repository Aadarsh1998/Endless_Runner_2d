using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour
{
    public static float pixelToUnit = 1.0f;
    public static float scale = 1.0f;

    public Vector2 nativeResolution; 
    private void Awake()
    {
        var cam = GetComponent<Camera>();
        if(cam.orthographic)
        {
            scale = Screen.height/nativeResolution.y;
            pixelToUnit *= scale;
            cam.orthographicSize = (Screen.height / 2.0f) / pixelToUnit;

        }
    }
}
