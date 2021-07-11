using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject ground;
    public SpawnManager spawner;

    private void Awake()
    {
        ground = GameObject.Find("Ground");
        spawner = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();

    }

    private void Start()
    {
        var groundHeight = ground.transform.localScale.y;
        var pos = ground.transform.position;
        pos.x = 0;
        pos.y = -(Screen.height / PixelPerfectCamera.pixelToUnit / 2) + (groundHeight / 2);
        ground.transform.position = pos;
        spawner.active = false;
        SetGame();
    }

    private void Update()
    {
        
    }

    void SetGame()
    {
        spawner.active = false;
        GameObject player = Instantiate(playerPrefab, new Vector3(0, (Screen.height / PixelPerfectCamera.pixelToUnit) / 2, 0), Quaternion.identity);
    }
}
