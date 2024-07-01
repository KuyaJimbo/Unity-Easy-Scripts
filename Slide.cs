using UnityEngine;

public class Slide : MonoBehaviour
{
    public float length = 1.0f; // The distance the block will move left from its original position
    public float duration = 2.0f; // The time it takes to move all the way left and right

    private Vector3 startPos;
    private float timeElapsed;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        float cycle = timeElapsed / duration;
        float sinWave = Mathf.Sin(cycle * Mathf.PI * 2.0f); // Create a sine wave from 0 to 1 and back to 0
        float offset = sinWave * length / 2.0f; // Scale the sine wave to the desired length
        transform.position = startPos + new Vector3(offset, 0, 0);
    }
}
