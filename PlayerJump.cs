using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Please make sure that the player has a collider and a rigidbody,
    // the collider is set to "Is Trigger",
    // the player has a tag of "Player",
    // and the ground objects have a tag of "Ground"

    // Set up variables
    private Rigidbody rb;
    public float speed = 10;

    // Set up variables for jumping
    private bool isGrounded;
    private bool canDoubleJump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // allow player to double jump
    void Update()
    {
        // If the player presses the space bar, call the DoubleJump function
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DoubleJump();
        }

        // OR if you want the player to single jump, call the SingleJump function
        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     SingleJump();
        // }

    }

    // If the player is grounded, allow them to jump
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            canDoubleJump = true;
        }
    }

    // Jump function
    void DoubleJump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
            isGrounded = false;
            canDoubleJump = true;
        }
        else
        {
            if (canDoubleJump)
            {
                rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
                canDoubleJump = false;
            }
        }
    }

    void SingleJump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * speed, ForceMode.Impulse);
            isGrounded = false;
        }
    }

}
