using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyData : MonoBehaviour
{
    [SerializeField]
    private int health;
    

    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
        Debug.Log(health);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            health--;
        }
    }
}
