using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFlow : MonoBehaviour
{
    [SerializeField]
    private Transform tileObj;
    private Vector3 nextTileSpawn;
    [SerializeField]
    private int platformLength;
    void Start()
    {
        nextTileSpawn.z = platformLength;
        StartCoroutine(spawnTile());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        nextTileSpawn.z += platformLength;
        StartCoroutine(spawnTile());

        /* destory object after 5 seconds
        yield return new WaitForSeconds(5);
        Destroy(tileObj);
        */
    }
}
