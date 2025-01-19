using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Transform playerStartPosition; 
    public GameObject nextDoor;
    public bool isRealDoor = false;

    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            if (!isRealDoor) 
            {
                other.transform.position = playerStartPosition.position;

                //next door
                if (nextDoor != null)
                {
                    nextDoor.GetComponent<SpriteRenderer>().enabled = true; 
                    nextDoor.GetComponent<BoxCollider2D>().enabled = true; 
                }

                spriteRenderer.enabled = false;
                boxCollider.enabled = false;
            }
        }
    }

}
