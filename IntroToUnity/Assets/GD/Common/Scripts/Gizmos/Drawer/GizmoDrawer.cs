using UnityEngine;
using Sirenix.OdinInspector;
using GD.Tools;

#region GD.Tools

/// <summary>
/// MonoBehaviour class to draw gizmos on a game object using an IDrawGizmo implementation.
/// </summary>
public class GizmoDrawer : MonoBehaviour
{
    [SerializeField, InlineEditor]
    [Tooltip("The gizmo to draw (Sphere or Cube).")]
    [RequireInterface(typeof(IDrawGizmo))]
    private ScriptableObject drawGizmoInterface;

    /// <summary>
    /// Draws the gizmo using the selected IDrawGizmo implementation.
    /// </summary>
    private void OnDrawGizmos()
    {
        // If typecastable, then draw the gizmo using the selected IDrawGizmo implementation.
        (drawGizmoInterface as IDrawGizmo)?.Draw(transform.position);
    }
}

#endregion GD.Tools