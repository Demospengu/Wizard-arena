using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float jumpForce = 10f;
    public HealthBar healthBar;

    private float moveInput;
    public float moveSpeed;

    private Rigidbody2D rb;


    private int jumpCount;
    public int maxJumps = 2;

    public Transform groundCheck;
    public float checkRadius = 0.1f;
    public LayerMask groundLayer;
    private bool isGrounded;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {



        // Ground check
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundLayer);


        if (isGrounded)
        {
            jumpCount = maxJumps;
            
        }

        // Jump input
        if (Input.GetKeyDown(KeyCode.UpArrow) && jumpCount > 0)
        {
            
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount--;
        }


        float moveInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(20);

        }

        


        void TakeDamage(int Damage)
        {
            currentHealth -= Damage;

            healthBar.SetHealth(currentHealth);
        }
    }
}

