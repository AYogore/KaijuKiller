using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> pickUps;

    private int leftBound;
    private int rightBound;

    //spawn location
    private float roadLength;
    private float roadOffset;

    void Start()
    {
        //bounds; transform positions of barriers in the game.
        leftBound = -7;
        rightBound = 6;
        //spawn location of road for cars
        roadLength = 30.0f;
        roadOffset = 140.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnPickUp()
    {
        //random PickUp in List
        int randomInt = Random.Range(0, pickUps.Count);
        GameObject randPickUp = pickUps[randomInt];

        //random X in bounds
        int randX = Random.Range(leftBound, rightBound);

        Vector3 pickUpSpawnLocation = new Vector3(randX, 1, roadOffset);
        roadOffset += roadLength;

        Instantiate(randPickUp, pickUpSpawnLocation, randPickUp.transform.rotation);




    }
}
