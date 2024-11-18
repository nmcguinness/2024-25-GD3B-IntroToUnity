using GD.Tools;
using GD.Types;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GD.Tools
{
    public abstract class DrawGizmo : ScriptableGameObject, IDrawGizmo
    {
        [Title("Appearance")]
        [SerializeField]
        [Tooltip("The color of the gizmo.")]
        [ColorPalette]
        protected Color gizmoColor = Color.white;

        public virtual void Draw(Vector3 position)
        {
            //NOOP
        }
    }
}