using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    RoadSpawner roadSpawner;
    CarSpawner carSpawner;
    PickUpSpawner pickUpSpawner;
    void Start()
    {
        roadSpawner = GetComponent<RoadSpawner>();
        carSpawner = GetComponent<CarSpawner>();
        pickUpSpawner = GetComponent<PickUpSpawner>();
    }

    
    public void SpawnTriggerEntered()
    {
        roadSpawner.MoveRoad();
        carSpawner.SpawnCar();
        pickUpSpawner.SpawnPickUp();
    }
}
