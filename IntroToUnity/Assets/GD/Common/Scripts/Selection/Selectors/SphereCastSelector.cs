using UnityEngine;

namespace GD.Selection
{
    public class SphereCastSelector : MonoBehaviour, ISelector
    {
        [SerializeField] private string selectableTag;
        [SerializeField] private float radius = 1;
        [SerializeField] private int maxDistance = 10;
        [SerializeField] private LayerMask layerMask = LayerMask.NameToLayer("Default");

        private Transform selection;
        private RaycastHit hitInfo;

        public void Check(Ray ray)
        {
            selection = null;

            if (Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask.value))
            {
                var currentSelection = hitInfo.transform;
                if (currentSelection.CompareTag(selectableTag))
                    selection = currentSelection;
            }
        }

        public RaycastHit GetHitInfo()
        {
            return hitInfo;
        }

        public Transform GetSelection()
        {
            return selection;
        }
    }
}