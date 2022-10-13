using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject[] tilePrefab; //should contain the obstacle and collectable
    public GameObject collectablePrefab;

    private float spawnZ = 0.0f;
    private int amountOfTiles = 3; //visible on the screen
    public float tileLength;
    Transform playerTransform;

    private void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for (int i = 0; i < amountOfTiles; i++)
        {
            SpawnPath();
        }
    }
    private void Update()
    {
        if(playerTransform.position.z > (spawnZ - amountOfTiles * tileLength))
        {
            SpawnPath();
        }
    }

    //instantiate an obstacle
    void SpawnObstacle()
    {
        //instantiate either x in -3, 0, 3
        //y in 0
        //z in maximum
        
    }
    void SpawnCollectables()
    {

    }
    void SpawnPath(int prefabIndex = -1)
    {
        GameObject gO;
        gO = Instantiate(tilePrefab[0]) as GameObject;
        gO.transform.SetParent(transform);
        gO.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }
}
