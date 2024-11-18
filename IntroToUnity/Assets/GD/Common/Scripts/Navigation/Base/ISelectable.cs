
using UnityEngine;

namespace GD.Navigation
{
    /// <summary>
    /// Interface for selectable objects.
    /// </summary>
    public interface ISelectable
    {
        void Select();
        void Deselect();
    }
}
