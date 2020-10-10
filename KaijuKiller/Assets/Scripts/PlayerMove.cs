using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10;

    [SerializeField]
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, moveSpeed);
    }

   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(-10, 0, moveSpeed);
            StartCoroutine(stopLaneChange());
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector3(10, 0, moveSpeed);
            StartCoroutine(stopLaneChange());
        }
    }

    IEnumerator stopLaneChange()
    {
        yield return new WaitForSeconds(0.5f);
        rb.velocity = new Vector3(0, 0, moveSpeed);
    }
}
