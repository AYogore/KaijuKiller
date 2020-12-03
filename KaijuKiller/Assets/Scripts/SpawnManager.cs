using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    CarSpawner carSpawner;
    PickUpSpawner pickUpSpawner;
    EnemySpawner enemySpawner;
    EnvironmentSpawn environmentSpawner;
    public static int activeEnemies = 0;
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        carSpawner = GetComponent<CarSpawner>();
        pickUpSpawner = GetComponent<PickUpSpawner>();
        enemySpawner = GetComponent<EnemySpawner>();
        environmentSpawner = GetComponent<EnvironmentSpawn>();
    }

    
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        carSpawner.SpawnCar();
        pickUpSpawner.SpawnPickUp();
        environmentSpawner.SpawnTile();

            enemySpawner.SpawnEnemy();

        

    }
}
