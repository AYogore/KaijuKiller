using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameFlow : MonoBehaviour
{
    [SerializeField]
    private Transform tileObj;
    private Vector3 nextTileSpawn;

    [SerializeField]
    private Transform obsObj;
    private Vector3 nextObsSpawn;

    [SerializeField]
    private List<Transform> pickUpsObj;
    private Vector3 nextPickUpsObjSpawn;


    [SerializeField]
    private int platformLength;
    private int randX;
    void Start()
    {
        nextTileSpawn.z = 160;
        StartCoroutine(spawnTile());
        StartCoroutine(spawnPickUps());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator spawnPickUps()
    {
        yield return new WaitForSeconds(2);
        int randItem = Random.Range(0, 2);
        randX = Random.Range(-5, 6);

        nextPickUpsObjSpawn = nextTileSpawn;
        nextPickUpsObjSpawn.x = randX;
        nextPickUpsObjSpawn.y = 1;


        for (int i = 1; i <= 10; i++)
        {
            Instantiate(pickUpsObj[randItem], nextPickUpsObjSpawn, pickUpsObj[randItem].rotation);
        }
        StartCoroutine(spawnPickUps());
    }
    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);

        randX = Random.Range(-5, 6);
        nextObsSpawn = nextTileSpawn;
        nextObsSpawn.x = randX;
        nextObsSpawn.y = 3;


        for (int i =1; i <= 10; i++)
        {
            Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
            Instantiate(obsObj, nextObsSpawn, obsObj.rotation);
            nextTileSpawn.z += 5;
        }
        
       // Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        //nextTileSpawn.z += 5;
        StartCoroutine(spawnTile());

        /* destory object after 5 seconds
        yield return new WaitForSeconds(5);
        Destroy(tileObj);
        */
    }
}
