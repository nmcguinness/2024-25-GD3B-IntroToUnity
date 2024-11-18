
using UnityEngine;
using Sirenix.OdinInspector;

namespace GD.Navigation
{
    /// <summary>
    /// Manages waypoints for navigation.
    /// </summary>
    public class WaypointManager : MonoBehaviour, IWaypointManager
    {
        [Title("Waypoint Settings")]
        [SerializeField, Tooltip("Prefab used for waypoints.")]
        private GameObject waypointPrefab;

        [SerializeField, Tooltip("Anchor object for waypoint positioning.")]
        private GameObject sceneAnchor;

        public void SetWaypoint(Vector3 position)
        {
            waypointPrefab.SetActive(true);
            waypointPrefab.transform.SetParent(sceneAnchor.transform);
            waypointPrefab.transform.position = position;
        }

        public void ClearWaypoint()
        {
            waypointPrefab.SetActive(false);
        }
    }
}
