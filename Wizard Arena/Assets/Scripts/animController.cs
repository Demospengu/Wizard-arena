using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationController : MonoBehaviour
{

    public float jumpForce = 1f;
    public float jumpInterval = 0.5f;
    private bool isGrounded;
    private Rigidbody2D rb;

   
    

    

    Animator animController;
    // Start is called before the first frame update
    void Start()
    {
        animController = GetComponent<Animator>();

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            animController.SetInteger("control", 1);



            if (Input.GetKeyDown(KeyCode.Space))
            {

                Jump();
            }

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpContinuously();
        }
    }

    void JumpContinuously()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);

    }
        void Jump()

        {

            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

    }

    
    

