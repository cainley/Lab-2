using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;              // Movement speed
    public float jumpSpeed = 10.0f;         // Jump height
    public float gravity = 5.0f;           // Gravity strength

    private float verticalVelocity = 0.0f;              // Vertical velocity for jumping and falling
    private CharacterController characterController;   // Reference to CharacterController component

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.TransformDirection(new Vector3(moveX, 0, moveZ)) * speed;

        // Jump
        if (characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpSpeed;
            }
        }

        // Apply gravity
        verticalVelocity -= gravity * Time.deltaTime;
        moveDirection.y = verticalVelocity;

        // Move the character
        characterController.Move(moveDirection * Time.deltaTime);
    }
}