using UnityEngine;
using Sirenix.OdinInspector;

namespace GD.Tools
{
    /// <summary>
    /// ScriptableObject for drawing a wireframe octahedron gizmo.
    /// </summary>
    [CreateAssetMenu(fileName = "WireframeOctahedronGizmo", menuName = "GD/Gizmos/Wireframe/Octahedron")]
    public class WireframeOctahedronGizmo : DrawGizmo
    {
        [Title("Octahedron Settings")]
        [Tooltip("The radius of the octahedron.")]
        [MinValue(0.1f)]
        public float radius = 1f;

        /// <summary>
        /// Draws a wireframe octahedron gizmo.
        /// </summary>
        /// <param name="position">The center position of the octahedron.</param>
        public override void Draw(Vector3 position)
        {
            Gizmos.color = gizmoColor;

            // Vertices of the octahedron
            Vector3 top = position + Vector3.up * radius;
            Vector3 bottom = position + Vector3.down * radius;

            Vector3 front = position + Vector3.forward * radius;
            Vector3 back = position + Vector3.back * radius;
            Vector3 left = position + Vector3.left * radius;
            Vector3 right = position + Vector3.right * radius;

            // Draw edges connecting the vertices
            // Top vertex to base vertices
            Gizmos.DrawLine(top, front);
            Gizmos.DrawLine(top, back);
            Gizmos.DrawLine(top, left);
            Gizmos.DrawLine(top, right);

            // Bottom vertex to base vertices
            Gizmos.DrawLine(bottom, front);
            Gizmos.DrawLine(bottom, back);
            Gizmos.DrawLine(bottom, left);
            Gizmos.DrawLine(bottom, right);

            // Base edges
            Gizmos.DrawLine(front, left);
            Gizmos.DrawLine(front, right);
            Gizmos.DrawLine(back, left);
            Gizmos.DrawLine(back, right);
        }
    }
}