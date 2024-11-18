
using UnityEngine;

namespace GD.Navigation
{
    /// <summary>
    /// Interface for waypoint management.
    /// </summary>
    public interface IWaypointManager
    {
        void SetWaypoint(Vector3 position);
        void ClearWaypoint();
    }
}
