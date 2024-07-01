using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 100.0f; // The speed of the rotation

    void Update()
    {
        // Rotate the object around its Y-axis at the specified speed
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
