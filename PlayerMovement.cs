using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    // Please make sure that the Player has a collider and a rigidbody
    // and that the collider is set to "Is Trigger"

    // Set up variables
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Uses the Input System to get the movement value
    void OnMove(InputValue movementValue)
    {
        // Function to calculate the movement direction based on the input value
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }

    // FixedUpdate has a fixed time step
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
}
