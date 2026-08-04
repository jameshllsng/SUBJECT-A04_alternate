using UnityEngine;

public class AccessCard : MonoBehaviour, IInteractable
{
  public void Interact(PlayerInventory playerInventory)
  {
    playerInventory.CollectAccessCard();
    Destroy(gameObject);
  }

}
