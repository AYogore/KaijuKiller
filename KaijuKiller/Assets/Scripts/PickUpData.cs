using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpData : MonoBehaviour
{
    [SerializeField]
    private int score;
    void Start()
    {
        
    }

    

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
