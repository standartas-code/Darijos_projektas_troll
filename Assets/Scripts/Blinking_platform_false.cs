using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blinking_platform_false : MonoBehaviour
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
                // platform yra, bet zaidejas krinta
                spriteRenderer.enabled = true; 
                boxCollider.isTrigger = true; 
            }
            else
            {
                // platfor nera, bet zaidejas gali stoveti
                spriteRenderer.enabled = false; 
                boxCollider.isTrigger = false; 
            }

            // waiting
            yield return new WaitForSeconds(isVisible ? visibleDuration : invisibleDuration);
        }
    }
}
