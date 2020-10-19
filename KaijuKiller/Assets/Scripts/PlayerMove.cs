using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10;

    [SerializeField]
    private float accelerationForce = 10.0f;

    [SerializeField]
    private float moveHorizontalSpeed = 10;

    
    private Rigidbody rb;

    //private Vector3 horizontalMovement;
    private Vector2 input;
    private int bounds;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(0, 0, moveSpeed);
        bounds = 0;

        //horizontalInput = Input.GetAxis("Horizontal") * moveHorizontalSpeed * Time.deltaTime;
        

       
    }

   

    // Update is called once per frame
    private void FixedUpdate()
    {
        var inputDirection = new Vector3(input.x, 0, input.y);

        //this.transform.position.y = 0;
        rb.AddForce(inputDirection* accelerationForce, ForceMode.Acceleration);

        /*
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
    */
    }
    private void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");

    }

    
}
