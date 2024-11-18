using UnityEngine;
using Sirenix.OdinInspector;
using GD.Types;

namespace GD.Tools
{
    /// <summary>
    /// ScriptableObject for drawing a wireframe arrow gizmo.
    /// </summary>
    [CreateAssetMenu(fileName = "WireframeArrowGizmo", menuName = "GD/Gizmos/Wireframe/Arrow")]
    public class WireframeArrowGizmo : DrawGizmo
    {
        [Title("Shape-specific Settings")]
        [SerializeField]
        [Tooltip("The length of the arrow.")]
        [Range(0.1f, 10f)]
        private float arrowLength = 1f;

        [SerializeField]
        [Tooltip("The width of the arrow head.")]
        [Range(0.1f, 5f)]
        private float arrowHeadWidth = 0.25f;

        [SerializeField]
        [Tooltip("The width of the sphere at the end of the arrow.")]
        [Range(0.01f, 0.5f)]
        private float endSphereWidth = 0.025f;

        [SerializeField]
        [Tooltip("The angle of the arrow head.")]
        [Range(0, 180)]
        private float arrowHeadAngle = 160f;

        /// <summary>
        /// Draws a wireframe arrow gizmo.
        /// </summary>
        /// <param name="position">The starting position of the arrow.</param>
        public override void Draw(Vector3 position)
        {
            Gizmos.color = gizmoColor;

            // Starting point of the arrow
            Vector3 startPoint = position;

            // Endpoint of the arrow in the direction of Vector3.forward
            Vector3 endPoint = startPoint + Vector3.forward * arrowLength;

            // Calculate arrowhead points
            Vector3 right = Quaternion.LookRotation(Vector3.forward) * Quaternion.Euler(0, arrowHeadAngle, 0) * Vector3.forward;
            Vector3 left = Quaternion.LookRotation(Vector3.forward) * Quaternion.Euler(0, -arrowHeadAngle, 0) * Vector3.forward;

            Vector3 rightHead = endPoint + right * arrowHeadWidth;
            Vector3 leftHead = endPoint + left * arrowHeadWidth;

            // Draw the main line of the arrow
            Gizmos.DrawLine(startPoint, endPoint);

            // Draw the arrowhead lines
            Gizmos.DrawLine(endPoint, rightHead);
            Gizmos.DrawLine(endPoint, leftHead);

            // Draw the base of the arrow as a sphere
            Gizmos.DrawSphere(startPoint, endSphereWidth);
        }
    }
}