using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private InputAction moveAction;
    private CharacterController controller;
    [SerializeField] private float moveSpeed = 5f;
    private InputAction jumpAction;
    private float verticalVelocity = 0f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpForce = 5f;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }
    
    private void Update()
        {
            Vector2 moveInput = moveAction.ReadValue<Vector2>();
            Vector3 moveDirection = transform.right * moveInput.x + transform.forward * moveInput.y;
            if (controller.isGrounded && verticalVelocity < 0f)
            {
                verticalVelocity = -2f;
            }
            if (jumpAction.WasPressedThisFrame() && controller.isGrounded)
            {
                verticalVelocity = jumpForce;
            }
            verticalVelocity += gravity * Time.deltaTime;
            Vector3 finalMove = moveDirection * moveSpeed;
            finalMove.y = verticalVelocity;
            controller.Move(finalMove * Time.deltaTime);
        }
}
