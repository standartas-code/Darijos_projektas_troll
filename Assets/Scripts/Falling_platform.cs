using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_platform : MonoBehaviour
{
    public float fallDelay = 0.5f;
    public float destroyDelay = 2f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Static;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke("Fall", fallDelay);
        }
    }

    private void Fall()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay); //delete platform
    }
}
