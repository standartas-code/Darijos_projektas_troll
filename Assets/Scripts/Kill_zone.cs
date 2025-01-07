using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_zone : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Sound();
            Invoke("RestartLevel", 2f);
        }
    }

    private void RestartLevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }

    private void Sound()
    {

        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
