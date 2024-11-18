using UnityEngine;
using Sirenix.OdinInspector;
using GD.Types;

namespace GD.Tools
{
    /// <summary>
    /// ScriptableObject for drawing a wireframe sphere gizmo.
    /// </summary>
    [CreateAssetMenu(fileName = "WireframeSphereGizmo", menuName = "GD/Gizmos/Wireframe/Sphere")]
    public class WireframeSphereGizmo : DrawGizmo
    {
        [Title("Shape-specific Settings")]
        [SerializeField]
        [Tooltip("The radius of the sphere.")]
        [MinValue(0.1f)]
        private float radius = 1f;

        /// <summary>
        /// Draw the sphere gizmo.
        /// </summary>
        /// <param name="position">The position to draw the sphere.</param>
        /// <param name="position">The starting position of the arrow.</param>
        public override void Draw(Vector3 position)
        {
            Gizmos.color = gizmoColor;
            Gizmos.DrawWireSphere(position, radius);
        }
    }
}