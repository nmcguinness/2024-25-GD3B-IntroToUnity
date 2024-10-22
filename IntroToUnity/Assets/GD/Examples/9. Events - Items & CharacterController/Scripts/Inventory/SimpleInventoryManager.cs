using GD;
using GD.Items;
using UnityEngine;

public class SimpleInventoryManager : MonoBehaviour
{
    [SerializeField]
    private Inventory inventory;

    public void OnInteractablePickup(ItemData data)
    {
        inventory.Add(data, 1);
    }
}