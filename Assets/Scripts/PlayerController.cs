using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpforce = 3f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private int jumpCount = 0;
    private int maxJumps = 2;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //judejimas   left right
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 (move * speed, rb.velocity.y);

        //i kuria puse ziuri 
        if(move > 0)
        {
            transform.localScale = new Vector3(6, 6.466916f, 10.66863f);
        }
        else if (move < 0)
        {
            transform.localScale = new Vector3 (-6, 6.466916f, 10.66863f);
        }


        //jump
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < maxJumps)
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            jumpCount++;
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
