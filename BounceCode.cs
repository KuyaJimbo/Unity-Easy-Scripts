using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCode : MonoBehaviour
{
    // Please make sure that the KillBrick has a collider and a rigidbody
    // and that the collider is set to "Is Trigger"

    // Set up variables
    private Rigidbody rb;
    public int bounceValue = 10; // update as needed
    public AudioSource bounceSound; // bounce sound

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        bounceSound = GetComponent<AudioSource>(); // initialize the bounce sound
    }

    // Update is called once per frame
    void Update()
    {

    }

    // If a player collides with the bounce object, make the player jump
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Make the other game object jump
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * bounceValue, ForceMode.Impulse);

            // Play bounce sound
            if (bounceSound != null)
            {
                bounceSound.Play();
            }
        }
    }
}
