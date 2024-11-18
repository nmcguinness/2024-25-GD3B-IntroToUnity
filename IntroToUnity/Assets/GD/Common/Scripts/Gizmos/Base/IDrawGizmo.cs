using UnityEngine;

namespace GD.Tools
{
    /// <summary>
    /// Interface for drawing gizmos.
    /// Implement this to define custom gizmo drawing behavior.
    /// </summary>
    public interface IDrawGizmo
    {
        /// <summary>
        /// Draw the gizmo at the specified position with the specified color.
        /// </summary>
        /// <param name="position">The position to draw the gizmo.</param>
        void Draw(Vector3 position);
    }
}