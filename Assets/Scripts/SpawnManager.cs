using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject enemyPrefab;
    float delayTime = 1.0f;
    public bool active = true;

    void Start()
    {
        Instantiate(enemyPrefab);
        StartCoroutine("ObstacleGenerator");  
    }
    IEnumerator ObstacleGenerator()
    {
        delayTime = Random.Range(5.0f, 7.0f);
        yield return new WaitForSeconds(delayTime);
        if(active)
        {
            ObjectPoolUtility.Instantiate(obstacles[Random.Range(0, obstacles.Length)], transform.position);
            StartCoroutine("ObstacleGenerator");
        }
        
        
    }
    
    
}
