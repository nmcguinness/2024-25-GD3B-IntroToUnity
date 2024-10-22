using GD.Items;
using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

namespace GD
{
    [CreateAssetMenu(fileName = "New Inventory",
menuName = "GD/Inventory/Inventory")]
    public class Inventory : SerializedScriptableObject
    {
        [SerializeField]
        private Dictionary<ItemData, int> contents = new Dictionary<ItemData, int>();

        public void Add(ItemData data, int amount)
        {
            if (contents.ContainsKey(data))
            {
                contents[data] += amount;
            }
            else
            {
                contents.Add(data, amount);
            }
        }

        public bool Remove(ItemData data, int amount)
        {
            if (contents.ContainsKey(data))
            {
                if (contents[data] >= amount)
                {
                    contents[data] -= amount;
                    if (contents[data] == 0)
                    {
                        contents.Remove(data);
                    }
                    return true;
                }
            }
            return false;
        }

        public int Count(ItemData data)
        {
            if (contents.ContainsKey(data))
            {
                return contents[data];
            }
            return 0;
        }
    }
}