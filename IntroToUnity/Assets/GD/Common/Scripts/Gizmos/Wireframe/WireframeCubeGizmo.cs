using UnityEngine;
using Sirenix.OdinInspector;
using GD.Types;

namespace GD.Tools
{
    /// <summary>
    /// ScriptableObject for drawing a wireframe cube gizmo.
    /// </summary>
    [CreateAssetMenu(fileName = "WireframeCubeGizmo", menuName = "GD/Gizmos/Wireframe/Cube")]
    public class WireframeCubeGizmo : DrawGizmo
    {
        [Title("Shape-specific Settings")]
        [SerializeField]
        [Tooltip("The size of the cube (width, height, depth).")]
        [MinValue(0.1f)]
        private Vector3 size = Vector3.one;

        /// <summary>
        /// Draw the cube gizmo.
        /// </summary>
        /// <param name="position">The position to draw the cube.</param>
        /// <param name="position">The starting position of the arrow.</param>
        public override void Draw(Vector3 position)
        {
            Gizmos.color = gizmoColor;
            Gizmos.DrawWireCube(position, size);
        }
    }
}