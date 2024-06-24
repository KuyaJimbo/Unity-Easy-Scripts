using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillBrickCode : MonoBehaviour
{
    // Please make sure that the KillBrick has a collider and a rigidbody
    // and that the collider is set to "Is Trigger"

    // Public variable to set the death sound
    public AudioSource deathSound;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the death sound
        deathSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // If the player collides with the kill brick, destroy the player, play the sound, then reload the scene
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Destroy the player object
            Destroy(other.gameObject);

            // Play the death sound and start coroutine to reload the scene after the sound finishes
            if (deathSound != null)
            {
                deathSound.Play();
                StartCoroutine(ReloadSceneAfterSound(deathSound.clip.length));
            }
            else
            {
                // If no sound is assigned, reload the scene immediately
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }

    // Coroutine to reload the scene after the sound finishes playing
    IEnumerator ReloadSceneAfterSound(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
