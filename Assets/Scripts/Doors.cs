using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public Transform playerStartPosition; 
    public GameObject nextDoor;
    public bool isRealDoor = false; 

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
                    Debug.Log("?????????? ????????? ?????!");
                    nextDoor.GetComponent<SpriteRenderer>().enabled = true; 
                    nextDoor.GetComponent<BoxCollider2D>().enabled = true; 
                }
            }
        }
    }

}
