using GD.Items;
using UnityEngine;

public class SimpleInventoryManager : MonoBehaviour
{
    [SerializeField]
    private SimpleInventory inventory;

    public void OnInteractablePickup(ItemData data)
    {
        inventory.Add(data, 1);
    }
}