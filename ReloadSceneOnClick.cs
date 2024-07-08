using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadSceneOnClick : MonoBehaviour
{
    private void Start()
    {
        // Get the button component attached to this GameObject
        Button button = GetComponent<Button>();

        // Add a listener to the button's onClick event to call the ReloadScene method when the button is clicked
        button.onClick.AddListener(ReloadScene);
    }

    // Method to reload the current scene
    private void ReloadScene()
    {
        // Get the active scene and reload it
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
