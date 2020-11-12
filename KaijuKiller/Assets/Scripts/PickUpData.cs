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



    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Destroy(this.gameObject);
            ScoreUI.IncrementScore(score);
        }
    }
}
