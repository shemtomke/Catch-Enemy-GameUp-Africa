using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] tilePrefab; //should contain the obstacle, path and collectibles

    private float spawnZ = 0.0f;
    private int amountOfTiles = 5; //visible on the game screen
    public float tileLength;
    public Transform playerTransform;

    private void Start()
    {
        for (int i = 0; i < amountOfTiles; i++)
        {
            //spawn the 4th tile on start - has no obstacles
            //give room for the player to move freely
            GameObject gO;
            gO = Instantiate(tilePrefab[4]) as GameObject;
            gO.transform.SetParent(transform);
            gO.transform.position = Vector3.forward * spawnZ;
            spawnZ += tileLength;
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
    void SpawnPath(int prefabIndex = -1)
    {
        int randomTile = Random.Range(0, tilePrefab.Length);

        GameObject gO;
        gO = Instantiate(tilePrefab[randomTile]) as GameObject;
        gO.transform.SetParent(transform);
        gO.transform.position = Vector3.forward * spawnZ;
        spawnZ += tileLength;
    }
}
