using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCode : MonoBehaviour
{
    // Please make sure that the Coin has a collider and a rigidbody
    // and that the collider is set to "Is Trigger"

    // Coin sound
    public AudioSource coinSound;
    public int coinValue = 1;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize the coin sound AudioSource
        coinSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        SpinCoin();
    }

    // If the player collides with the coin, play the sound and destroy the coin
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Play coin sound
            coinSound.Play();

            // Disable the coin's visuals and collider to simulate immediate destruction
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;

            // Destroy the coin after the sound has played
            Destroy(gameObject, coinSound.clip.length);

            // Uncomment the line below to add coins to the player's coin count 
            // AddCoins(coinValue);
        }
    }

    // Spin the coin
    void SpinCoin()
    {
        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }

    // Add coins to the player's coin count
    public void AddCoins(int coinCount)
    {
        coinCount += coinValue;
    }
}
