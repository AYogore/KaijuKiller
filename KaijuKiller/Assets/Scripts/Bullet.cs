using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float bulletSpeed;

    Vector3 bulletVector;
    // Start is called before the first frame update
    void Start()
    {
        bulletVector = new Vector3(0, 0, bulletSpeed);
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * bulletSpeed;
    }

   

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            ScoreUI.score -= 5;
        }

        if (other.tag == "Enemy")
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            ScoreUI.IncrementScore();
            SpawnManager.activeEnemies = 0;
        }




    }
}
