using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blinking_platform_real : MonoBehaviour
{

    public float visibleDuration = 1f; 
    public float invisibleDuration = 1f;

    private SpriteRenderer spriteRenderer; 
    private BoxCollider2D boxCollider; 
    private bool isVisible = true; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();

        StartCoroutine(Blink()); //ciklas
    }

    IEnumerator Blink()
    {
        while (true)
        {
            isVisible = !isVisible;

            if (isVisible)
            {
                // platform nera, zaidejas krinta
                spriteRenderer.enabled = false; 
                boxCollider.isTrigger = true; 
            }
            else
            {
                // platfor yra, zaidejas gali stoveti
                spriteRenderer.enabled = true; 
                boxCollider.isTrigger = false; 
            }

            // waiting
            yield return new WaitForSeconds(isVisible ? visibleDuration : invisibleDuration);
        }
    }
}
