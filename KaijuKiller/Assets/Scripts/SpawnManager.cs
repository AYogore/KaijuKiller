using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    CarSpawner carSpawner;
    PickUpSpawner pickUpSpawner;
    EnemySpawner enemySpawner;
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        carSpawner = GetComponent<CarSpawner>();
        pickUpSpawner = GetComponent<PickUpSpawner>();
        enemySpawner = GetComponent<EnemySpawner>();
    }

    
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        carSpawner.SpawnCar();
        pickUpSpawner.SpawnPickUp();
        enemySpawner.SpawnEnemy();
    }
}
