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
        roadOffset = 300.0f;
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

        Vector3 pickUpSpawnLocation = new Vector3(randX, 2, roadOffset);
        roadOffset += roadLength;

        //pickUp randomizer

        int spawnRate = 0;
        
        if(ScoreUI.score == 0)
        {
            spawnRate = 1;
        }
        else if(ScoreUI.score >= 20)
        {
            spawnRate = 2;
        }
        else if (ScoreUI.score >= 30)
        {
            spawnRate = 3;
        }
        else if (ScoreUI.score >= 40)
        {
            spawnRate = 4;
        }
        else if (ScoreUI.score >= 50)
        {
            spawnRate = 5;
        }
        else if (ScoreUI.score >= 60)
        {
            spawnRate = 6;
        }
        else if (ScoreUI.score >= 70)
        {
            spawnRate = 7;
        }
        else if (ScoreUI.score >= 80)
        {
            spawnRate = 8;
        }


        int pickUpRandom = Random.Range(0, 20);
        if (pickUpRandom >= spawnRate)
        {
            Instantiate(randPickUp, pickUpSpawnLocation, randPickUp.transform.rotation);
        }



    }
}
