using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAtInterval : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroyTile());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator destroyTile()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }

    
}
