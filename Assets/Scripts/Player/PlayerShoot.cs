using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerShoot : MonoBehaviour
{
    private InputAction fireAction;

    private void Start()
    {
        
        fireAction = InputSystem.actions.FindAction("Fire");
    }

    private void Update()
    {
        if (fireAction.WasPressedThisFrame())
        {
            Debug.Log("Disparo!");
        }
    }
}
