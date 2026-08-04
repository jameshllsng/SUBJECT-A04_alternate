using UnityEngine;

public class TestButton : MonoBehaviour, IInteractable
{
  public void Interact(PlayerInventory playerInventory)
  {
    Debug.Log("Botão acionado.");
  }

}
