using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private InputAction moveAction;
    private CharacterController controller;
    [SerializeField] private float moveSpeed = 5f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }
    
    private void Update()
        {
            Vector2 moveInput = moveAction.ReadValue<Vector2>();
            Vector3 moveDirection = transform.right * moveInput.x + transform.forward * moveInput.y;
            controller.Move(moveDirection * moveSpeed * Time.deltaTime);
        }
}
