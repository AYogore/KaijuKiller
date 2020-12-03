using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float horizontalAccelerationForce;

    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private float jumpSpeed;

    private Vector2 input;
    private int bounds;
    private bool isLaneChanging;
    private bool isJumping;
    [SerializeField]
    private float gravityForce;

    Animator anim;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //getting anim component in player body
        anim = GetComponent<Animator>();
        //change to enum state
        isLaneChanging = false;
        isJumping = false;
        rb.velocity = new Vector3(0, 0, moveSpeed);
        bounds = 0;
         

        
    }

    private void FixedUpdate()
    {
        //side scroll
        var inputDirection = new Vector3(input.x * horizontalAccelerationForce, gravityForce, moveSpeed);
        rb.velocity = inputDirection;

        //jump
        //gravity
        
            var gravity = new Vector3(0, gravityForce, 0);
            //rb.AddForce(gravity, ForceMode.Impulse);

    }


    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
            
            isJumping = true; // switch to states soon

            //set anim bool is jumping
            anim.SetBool("isJumping", true);
            Debug.Log("JUMP");
        }
        else
        {
            //reset to running when not jumping
            anim.SetBool("isJumping", false);

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
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
