using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRolling : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 offset;
    Material mat;

    void Start()
    {
       mat = GetComponent<Renderer>().material;
       offset = mat.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset += speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
    }
}
