using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PitchBoundary : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        // Check if the object is the ball
        if (other.gameObject.name == "Ball")
        {
            // Restart the level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
