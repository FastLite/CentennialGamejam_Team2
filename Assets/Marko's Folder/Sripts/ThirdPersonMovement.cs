using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 moveDir = Vector3.zero;

    public float speed = 6f;

    Vector3 velocity;

    public float gravity = -9.81f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public float jumpHeight = 3f;
    public float dbJumpMultiplier = 0.5f;

    public bool isGrounded;
    public bool canDoubleJump;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        velocity.y += gravity * Time.deltaTime;

        if (isGrounded || canDoubleJump)
        {
            if (Input.GetButtonDown("Jump") && canDoubleJump == false)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
                canDoubleJump = true;
            }
            else
            {
                if (Input.GetButtonDown("Jump") && canDoubleJump == true)
                {
                    velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity) * dbJumpMultiplier;
                    canDoubleJump = false;
                }
            }
        }

        controller.Move(velocity * Time.deltaTime);

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * speed * Time.deltaTime);
            
        }
    }
}
