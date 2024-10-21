﻿using UnityEngine;

namespace GD.Items
{
    /// <summary>
    /// Represents an item that can be consumed by a game object on the correct layer
    /// </summary>
    public class Item : MonoBehaviour, IConsumable
    {
        [SerializeField]
        [Tooltip("The item data that represents this item")]
        private ItemData itemData;

        [SerializeField]
        [Tooltip("The event that is raised when this item is consumed")]
        private ItemGameEvent onItemEvent;

        [SerializeField]
        [Tooltip("The layer that the item can be picked up by")]
        private LayerMask targetLayer;

        /// <summary>
        /// Consumes the item
        /// </summary>
        /// <param name="consumer">Reference to consuming object</param>
        public void Consume(GameObject consumer)
        {
            Debug.Log("Consuming item: " + itemData.name);
        }

        /// <summary>
        /// Called when the item is picked up by a game object on the target layer
        /// </summary>
        /// <param name="other">Reference to collider object triggering response</param>
        private void OnTriggerEnter(Collider other)
        {
            if (targetLayer.OnLayer(other.gameObject))
            {
                //notify listeners that the item has been picked up
                onItemEvent?.Raise(itemData);

                //remove the object from the scene
                Destroy(gameObject);
            }
        }
    }
}