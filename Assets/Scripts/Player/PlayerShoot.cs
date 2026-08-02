using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerShoot : MonoBehaviour
{
    private InputAction fireAction;
    private Transform playerCamera;
    [SerializeField] private float weaponRange = 100f;
    [SerializeField] private float weaponDamage = 20f;

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
            if (hit.collider.TryGetComponent<TargetHealth>(out TargetHealth target))
            {
                target.TakeDamage(weaponDamage);
            }
            Debug.Log("Objeto:" + hit.collider.name + "Distância" + hit.distance);
        }
    }
    
}
