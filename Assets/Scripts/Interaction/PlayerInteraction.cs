using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    private InputAction interactAction;
    private Transform playerCamera;
    private PlayerInventory playerInventory;
    [SerializeField] private float interactionRange = 3f;

    private void Awake()
    {
        playerInventory = GetComponent<PlayerInventory>();
    }

    private void Start()
    {
        playerCamera = Camera.main.transform;
        interactAction = InputSystem.actions.FindAction("Interact");
    }

    private void Update()
    {
        if (interactAction.WasPressedThisFrame())
        {
            TryInteract();   
        }
    }

    private void TryInteract()
    {
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out RaycastHit hit, interactionRange))
        {
            if (hit.collider.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                interactable.Interact(playerInventory);
            }
        }
    }
}
