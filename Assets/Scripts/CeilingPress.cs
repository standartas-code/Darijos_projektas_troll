using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingPress : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // delete player 
            Destroy(collision.gameObject);
        }
        
        
    }
}
