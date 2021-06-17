using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMatchResolution : MonoBehaviour
{

    [SerializeField]
    int textureSize = 1;
    public bool scaleHorizontally;
    public bool scaleVertically;

    void Start()
    {
        //if(!scaleHorizontally ==1)
        //{
        //    var newWidth = Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
        //}


        var newWidth = ! scaleHorizontally?1: Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale));
        var newHeight = !scaleVertically?1:Mathf.Ceil(Screen.height / (textureSize * PixelPerfectCamera.scale));
        transform.localScale = new Vector3(newWidth * textureSize, newHeight * textureSize, 1);

        GetComponent<Renderer>().material.mainTextureScale = new Vector3(newWidth, newHeight, 1);
        
    }

    void Update()
    {
        
    }
}
