using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject []obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if (!playerControllerScript.gameOver)
        {
            int randomObstacle = Random.Range(0, obstaclePrefab.Length); 
            Instantiate(obstaclePrefab[3], spawnPos, obstaclePrefab[3].transform.rotation);
        }
    }
}
