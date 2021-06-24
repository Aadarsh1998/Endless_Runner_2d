using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    float delayTime = 2.0f;
    bool active = true;

    void Start()
    {
        StartCoroutine("ObstacleGenerator");  
    }
    IEnumerator ObstacleGenerator()
    {
        yield return new WaitForSeconds(delayTime);
        if(active)
        {
            ObjectPoolUtility.Instantiate(obstacles[Random.Range(0, obstacles.Length)], transform.position);
            StartCoroutine("ObstacleGenerator");
        }
        
        
    }
    
    
}
