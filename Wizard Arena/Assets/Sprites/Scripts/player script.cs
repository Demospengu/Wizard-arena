using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public float jumpForce = 1f;
    public HealthBar healthBar;

    private float moveInput;
    public float moveSpeed;

    private Rigidbody2D rb;

    



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

        if (Input.GetKeyDown(KeyCode.UpArrow))

        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

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

