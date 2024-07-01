using UnityEngine;

public class Float : MonoBehaviour
{
    public float height = 1.0f; // The height the block will move from its original position
    public float duration = 2.0f; // The time it takes to move all the way up and down

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
        float offset = sinWave * height / 2.0f; // Scale the sine wave to the desired height
        transform.position = startPos + new Vector3(0, offset, 0);
    }
}
