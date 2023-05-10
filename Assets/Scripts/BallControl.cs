using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float forceStrength = 5.0f;
    public float kickStrength = 5.0f;
    public float distanceToKick = 2.0f;
    public GameObject Player;
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is the player
        if (collision.gameObject.name == "Player")
        {
            // Apply an impulse force
            Vector3 direction = (transform.position - collision.transform.position).normalized;
            rb.AddForce(direction * forceStrength, ForceMode.Impulse);
        }
    }

    void Update()
    {
        float distance = Vector3.Distance(rb.transform.position, Player.transform.position);

        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space) && distance <= distanceToKick)
        {
            Vector3 direction = (rb.transform.position - Player.transform.position).normalized;

            // Apply an impulse force in the player's forward direction
            rb.AddForce(direction * kickStrength, ForceMode.Impulse);
        }
    }
}
