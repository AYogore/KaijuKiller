using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject firepoint;

    
    private float fireRate = 2;
    private bool canShoot = true;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && canShoot == true)
        {
            StartCoroutine(Fire());
        }

        /*OG Simple fire code
         * if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, firepoint.transform.position, bulletPrefab.transform.rotation);
            Debug.Log("Pew");
        }
        */
        

    }

    IEnumerator Fire()
    {
        Instantiate(bulletPrefab, firepoint.transform.position, bulletPrefab.transform.rotation);
        canShoot = false;
        float wait = 1 / fireRate;
        yield return new WaitForSeconds(wait);
        canShoot = true;
    }
}
