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
        private Dictionary<string, Inventory> content =
            new Dictionary<string, Inventory>();

        //add

        //remove

        //count

        //clear
    }
}