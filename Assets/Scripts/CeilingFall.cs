using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CeilingFall : MonoBehaviour
{
    public GameObject fallingCeiling; 
    public float fallSpeed = 5f; 

    private Rigidbody2D ceilingRigidbody;

    void Start()
    {
        if (fallingCeiling != null)
        {
            ceilingRigidbody = fallingCeiling.GetComponent<Rigidbody2D>();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            if (ceilingRigidbody != null)
            {
                ceilingRigidbody.bodyType = RigidbodyType2D.Dynamic;
                ceilingRigidbody.gravityScale = fallSpeed; 
            }
        }
    }

}
