using GD.Items;
using UnityEngine;

namespace GD
{
    public class InventoryManager : MonoBehaviour
    {
        [SerializeField]
        private InventoryCollection inventoryCollection;

        public void OnInteractablePickup(ItemData data)
        {
            inventoryCollection.Add(data.ItemCategory, data, data.Value);
        }
    }
}