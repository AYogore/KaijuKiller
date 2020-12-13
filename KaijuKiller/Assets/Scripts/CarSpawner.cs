using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> cars;

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

    public void SpawnCar()
    {
        //random car in List
        int randomInt = Random.Range(0, cars.Count);
        GameObject randCar = cars[randomInt];

        //random X in bounds
        int randX = Random.Range(leftBound, rightBound);

        Vector3 carSpawnLocation = new Vector3(randX, 0, roadOffset);
        roadOffset += roadLength;

        //car randomizer
        int carRandom = Random.Range(0, 20);

        int spawnRate = 0;

        if (ScoreUI.score == 0)
        {
            spawnRate = 0;
        }
        else if (ScoreUI.score >= 20)
        {
            spawnRate = 2;
        }
        
        else if (ScoreUI.score >= 40)
        {
            spawnRate = 4;
        }
        
        else if (ScoreUI.score >= 60)
        {
            spawnRate = 6;
        }
        
        

        if (carRandom <= spawnRate)
        {
            Instantiate(randCar, carSpawnLocation, randCar.transform.rotation);
        }
        
        

    }

    

}
