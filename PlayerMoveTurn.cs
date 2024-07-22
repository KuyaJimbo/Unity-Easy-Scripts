using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveTurn : MonoBehaviour
{
    // Speed for movement and rotation
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    // add rigidbody
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Handle movement manually
        if (Input.GetKey(KeyCode.W))
        {
            // Move the player forward with addForce
            rb.AddForce(transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Move the player backward with addForce
            rb.AddForce(-transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // Move the player left with addForce
            rb.AddForce(-transform.right * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Move the player right with addForce
            rb.AddForce(transform.right * moveSpeed);
        }
        // Handle rotation
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}

