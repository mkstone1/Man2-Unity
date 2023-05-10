using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float traction = 0.1f;
    private CharacterController characterController;
    private float planeWidth = 700f;  // Half the scale of your plane on the x-axis
    private float planeHeight = 1000f;  // Half the scale of your plane on the z-axis

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
        movement = Vector3.Lerp(Vector3.zero, movement, traction);

        characterController.Move(movement);

        // After moving, check if the player is out of bounds
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -planeWidth / 2, planeWidth / 2);
        position.z = Mathf.Clamp(position.z, -planeHeight / 2, planeHeight / 2);
        transform.position = position;
    }
}
