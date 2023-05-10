using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject ball; // Assign this in the Inspector
    public Vector3 offset; // The offset distance between the camera and ball

    void Update()
    {
        // Update the camera's position to the ball's position plus the offset.
        transform.position = ball.transform.position + offset;
    }
}
