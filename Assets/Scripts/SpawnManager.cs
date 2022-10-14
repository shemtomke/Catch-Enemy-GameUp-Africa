using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] tilePrefab; //should contain the obstacle and collectable
    //public GameObject collectablePrefab;

    private float spawnZ = 0.0f;
    private int amountOfTiles = 5; //visible on the screen
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
        //player position to destroy tiles which are behind
        if(playerTransform.position.z > (spawnZ - amountOfTiles * tileLength))
        {
            SpawnPath();
        }
    }
    void SpawnCollectables()
    {

    }
    void SpawnPath(int prefabIndex = -1)
    {
        int randomTile = Random.Range(0, tilePrefab.Length);

        GameObject gO;
        gO = Instantiate(tilePrefab[0]) as GameObject;
        gO.transform.SetParent(transform);
        gO.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }
}
