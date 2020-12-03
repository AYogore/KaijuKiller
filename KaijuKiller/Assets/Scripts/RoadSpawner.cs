using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField]
    //private Transform roadTile;
    private List<GameObject> roadGO;
    private float roadLength;
    private float roadOffset;
    Vector3 offset;
    private void Start()
    {
        roadLength = 30.0f;
        roadOffset = 110.0f;
        offset = new Vector3(0, 0, roadOffset);


        //save power by moving rather than keep instantiating
        //reorganizes list
        
        if(roadGO != null && roadGO.Count > 0)
        {
            roadGO = roadGO.OrderBy(r => r.transform.position.z).ToList();
        }
        

    }
    
    public void MoveRoad()
    {
        GameObject movedRoad = roadGO[0];
        roadGO.Remove(roadGO[0]);
        float newZ = roadGO[roadGO.Count - 1].transform.position.z + roadLength;
        movedRoad.transform.position = new Vector3(0, 0, newZ);
        roadGO.Add(movedRoad);
    }
    
}
