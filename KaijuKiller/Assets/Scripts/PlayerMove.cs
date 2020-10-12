using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float jumpSpeed;

    private int bounds;
    private bool isLaneChanging;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isLaneChanging = false;
        isJumping = false;
        rb.velocity = new Vector3(0, 0, moveSpeed);
        bounds = 0;
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if(bounds > -1 && !isLaneChanging)
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                isLaneChanging = true;
                rb.velocity = new Vector3(-10, 0, moveSpeed);
                StartCoroutine(stopLaneChange(-1));
                //bounds -= 1; //bug
            }
        }
        
        if(bounds < 1 && !isLaneChanging)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                isLaneChanging = true;
                rb.velocity = new Vector3(10, 0, moveSpeed);
                StartCoroutine(stopLaneChange(1));
                //bounds += 1; //bug
            }
        }

        if(isJumping == false)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector3(0, jumpSpeed, moveSpeed);
                isJumping = true;
                StartCoroutine(stopJump());
            }
        }
        
    }

    IEnumerator stopLaneChange(int i)
    {
        yield return new WaitForSeconds(0.5f);
        rb.velocity = new Vector3(0, 0, moveSpeed);
        bounds += i;
        isLaneChanging = false;
    }

    IEnumerator stopJump()
    {
       //lane change bug
        yield return new WaitForSeconds(0.5f);
        rb.velocity = new Vector3(0, -5, moveSpeed);
        yield return new WaitForSeconds(0.5f);
        rb.velocity = new Vector3(0, 0, moveSpeed);
        isJumping = false;
    }
}
