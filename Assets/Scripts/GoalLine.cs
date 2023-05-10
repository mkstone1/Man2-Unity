using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalLine : MonoBehaviour
{
    private AudioSource audioSource;

    // Get the reference to the AudioSource component
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the object is the ball
        if (other.gameObject.name == "Ball")
        {
            Rigidbody ballRigidbody = other.gameObject.GetComponent<Rigidbody>();

            // Stop the ball from moving
            ballRigidbody.velocity = Vector3.zero;
            ballRigidbody.angularVelocity = Vector3.zero;
            audioSource.Play();

            StartCoroutine(WaitAndLoadMenu());
        }
    }

    IEnumerator WaitAndLoadMenu()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(2);

        // Then load the main menu scene
        SceneManager.LoadScene("MainMenu"); // replace "MainMenu" with the name of your main menu scene
    }
}
