using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject firepoint;

    
    private int fireRate = 2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bulletPrefab, firepoint.transform.position, bulletPrefab.transform.rotation);
            Debug.Log("Pew");
        }
    }

    IEnumerator Fire()
    {
        yield return new WaitForSeconds(1 / fireRate);
        if (Input.GetButtonDown("Fire1"))
        {
            //Instantiate(bulletPrefab, firepoint, bulletPrefab.transform.rotation);
            Debug.Log("Pew");
        }
    }
}
