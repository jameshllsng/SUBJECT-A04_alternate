using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerShoot : MonoBehaviour
{
    private InputAction fireAction;
    private Transform playerCamera;
    [SerializeField] private float weaponRange = 100f;

    private void Start()
    {
        playerCamera = Camera.main.transform;
        fireAction = InputSystem.actions.FindAction("Fire");
    }

    private void Update()
    {
        if (fireAction.WasPressedThisFrame())
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (Physics.Raycast(playerCamera.position, playerCamera.forward, out RaycastHit hit, weaponRange))
        {   
            Debug.Log(hit.collider.name, hit.distance);
        }
    }
    
}
