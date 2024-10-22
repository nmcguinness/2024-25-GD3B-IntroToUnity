using GD.Items;
using GD.Types;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace GD
{
    [CreateAssetMenu(fileName = "New Inventory Collection",
menuName = "GD/Inventory/Inventory Collection")]
    public class InventoryCollection : SerializedScriptableObject
    {
        [SerializeField]
        private Dictionary<ItemCategoryType, Inventory> content =
            new Dictionary<ItemCategoryType, Inventory>();

        //add
        public void Add(ItemCategoryType key, ItemData data, int amount)
        {
            if (content.ContainsKey(key))
            {
                content[key].Add(data, amount);
            }
            else
            {
                Inventory inventory = ScriptableObject.CreateInstance<Inventory>();
                inventory.Add(data, amount);
                content.Add(key, inventory);
            }
        }

        //remove
        public bool Remove(ItemCategoryType key, ItemData data, int amount)
        {
            if (content.ContainsKey(key))
            {
                return content[key].Remove(data, amount);
            }
            return false;
        }

        //count
        public int Count(ItemCategoryType key, ItemData itemData)
        {
            if (content.ContainsKey(key))
            {
                var inventory = content[key];
                return inventory.Count(itemData);
            }

            return 0;
        }

        //TODO - clear
    }
}