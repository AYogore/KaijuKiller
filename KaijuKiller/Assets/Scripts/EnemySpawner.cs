using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> enemies;

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

    public void SpawnEnemy()
    {
        //random Enemyp in List
        int randomInt = Random.Range(0, enemies.Count);
        GameObject randPickUp = enemies[randomInt];

        //random X in bounds
        int randX = Random.Range(leftBound, rightBound);

        Vector3 enemySpawnLocation = new Vector3(randX, 0, roadOffset);
        roadOffset += roadLength;


        //randomizer so enemies dont always spawn
        int enemyRandom = Random.Range(0, 20); //d20 cuz dnd lawl

        if(enemyRandom >= 8)
        {
            Instantiate(randPickUp, enemySpawnLocation, randPickUp.transform.rotation);
        }
    }
}
