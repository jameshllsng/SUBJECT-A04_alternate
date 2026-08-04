using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private bool hasAccessCard;

    public void CollectAccessCard()
    {
        hasAccessCard = true;
        Debug.Log("Cartão de acesso coletado.");

    }
}
