using UnityEngine;
using Sirenix.OdinInspector;

namespace GD.Tools
{
    /// <summary>
    /// ScriptableObject for drawing a wireframe pyramid (four-sided pyramid) gizmo.
    /// </summary>
    [CreateAssetMenu(fileName = "WireframePyramidGizmo", menuName = "GD/Gizmos/Wireframe/Pyramid")]
    public class WireframePyramidGizmo : DrawGizmo
    {
        [Title("Pyramid Settings")]
        [Tooltip("The height of the pyramid.")]
        [MinValue(0.1f)]
        public float height = 1f;

        [Tooltip("The base width of the pyramid.")]
        [MinValue(0.1f)]
        public float baseWidth = 1f;

        /// <summary>
        /// Draws a wireframe pyramid gizmo.
        /// </summary>
        /// <param name="position">The center of the pyramid's base.</param>
        public override void Draw(Vector3 position)
        {
            Gizmos.color = gizmoColor;

            // Calculate the offset to position the pyramid so its geometric center matches `position`
            float halfHeight = height / 2;
            float halfBase = baseWidth / 2;

            // Apex of the pyramid
            Vector3 apex = position + new Vector3(0, halfHeight, 0);

            // Base vertices (square on the horizontal plane)
            Vector3 frontLeft = position + new Vector3(-halfBase, -halfHeight, halfBase);
            Vector3 frontRight = position + new Vector3(halfBase, -halfHeight, halfBase);
            Vector3 backLeft = position + new Vector3(-halfBase, -halfHeight, -halfBase);
            Vector3 backRight = position + new Vector3(halfBase, -halfHeight, -halfBase);

            // Draw base edges
            Gizmos.DrawLine(frontLeft, frontRight);
            Gizmos.DrawLine(frontRight, backRight);
            Gizmos.DrawLine(backRight, backLeft);
            Gizmos.DrawLine(backLeft, frontLeft);

            // Draw edges connecting the apex to the base vertices
            Gizmos.DrawLine(apex, frontLeft);
            Gizmos.DrawLine(apex, frontRight);
            Gizmos.DrawLine(apex, backLeft);
            Gizmos.DrawLine(apex, backRight);
        }
    }
}