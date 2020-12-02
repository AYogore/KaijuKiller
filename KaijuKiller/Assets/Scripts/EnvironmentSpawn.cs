using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSpawn : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> eTiles;

    private int leftBound;
    private int rightBound;

    //spawn location
    private float roadLength;
    private float roadOffset;

    void Start()
    {
        //will put this into spawn manager once converted to simpleton
        //bounds; transform positions of barriers in the game.
        leftBound = -7;
        rightBound = 6;
        //spawn location of road for cars
        roadLength = 30.0f;
        roadOffset = 140.0f;
    }


    public void SpawnTile()
    {
        //random tile in List
        int randomInt = Random.Range(0, eTiles.Count);
        GameObject randETile = eTiles[randomInt];

        //random X in bounds
        int leftTileX = -15;
        int rightTileX = 15;

        Vector3 eTileLSpawnLocation = new Vector3(leftTileX, 0, roadOffset);
        Vector3 eTileRSpawnLocation = new Vector3(rightTileX, 0, roadOffset);

        Instantiate(randETile, eTileLSpawnLocation, randETile.transform.rotation);
        Instantiate(randETile, eTileRSpawnLocation, randETile.transform.rotation);


        roadOffset += roadLength;
    }
}
