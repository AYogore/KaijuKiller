using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    CarSpawner carSpawner;
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        carSpawner = GetComponent<CarSpawner>();
    }

    
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        carSpawner.SpawnCar();
    }
}
