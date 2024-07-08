using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowButtonOnTouch : MonoBehaviour
{
    public Button uiButton; // The UI button to show

    private void Start()
    {
        // Ensure the button is initially hidden
        uiButton.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Show the UI button
            uiButton.gameObject.SetActive(true);
        }
    }
}
