using UnityEngine;

public class TargetHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    private float currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0f)
        {
            Destroy(gameObject);
        }
        Debug.Log(currentHealth);
    }

}
