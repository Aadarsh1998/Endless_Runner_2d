using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    RaycastHit hit;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Debug.DrawRay(ray.origin, ray.direction*20, Color.red, Mathf.Infinity);
            if(Physics.Raycast(ray,out hit,Mathf.Infinity))
            {
                Debug.Log("I hit something");
                Debug.Log("Touch phase began");
                Destroy(hit.transform.gameObject);
                
            }
            
            
            
            
            /* if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("Touch Started");
            } if(Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Debug.Log("Move Started");
            } if(Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                Debug.Log("Ended");
            }*/
            

            //Touch touch = Input.GetTouch(0);
            //foreach(Touch item in Input.touches)
            //{
            //    Debug.Log(item.position);
            //}
            //Debug.Log(Input.GetTouch(0).position);
        }
    }
}
