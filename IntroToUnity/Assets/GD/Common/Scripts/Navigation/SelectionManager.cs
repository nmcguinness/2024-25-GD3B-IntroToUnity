
using UnityEngine;
using Sirenix.OdinInspector;

namespace GD.Navigation
{
    /// <summary>
    /// Manages selection and deselection of objects.
    /// </summary>
    public class SelectionManager : MonoBehaviour, ISelectable
    {
        [Title("Selection Settings")]
        [SerializeField, Tooltip("Prefab used to indicate selection.")]
        private GameObject selectionPrefab;

        public void Select()
        {
            selectionPrefab.SetActive(true);
        }

        public void Deselect()
        {
            selectionPrefab.SetActive(false);
        }
    }
}
