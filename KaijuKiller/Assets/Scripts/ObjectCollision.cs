using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{
    [SerializeField]
    private GameObject deathScreen;

    PlayerMove playerMove;

    void Start()
    {
        deathScreen.SetActive(false);
        playerMove = GetComponent<PlayerMove>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            //playerMove.move;
            deathScreen.SetActive(true);
        
        }
    }
}
