using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCode : MonoBehaviour
{
    // Set up variables
    // main theme music
    public AudioClip mainTheme;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component and set it up
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = mainTheme;
        audioSource.loop = true;
        audioSource.Play(); // Play the audio in the Start method to ensure it starts once
    }

    // Update is called once per frame
    void Update()
    {
        // No need to call Play() every frame; it is already looping
    }
}
