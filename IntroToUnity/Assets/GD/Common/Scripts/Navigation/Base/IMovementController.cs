
using UnityEngine;

namespace GD.Navigation
{
    /// <summary>
    /// Interface for movement control.
    /// </summary>
    public interface IMovementController
    {
        void MoveTo(Vector3 destination);
        void StopMovement();
    }
}
