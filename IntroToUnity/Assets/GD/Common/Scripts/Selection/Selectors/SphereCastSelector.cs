using UnityEngine;

namespace GD.Selection
{
    public class SphereCastSelector : MonoBehaviour, ISelector
    {
        private string selectableTag;
        private float radius;
        private int maxDistance;
        private LayerMask layerMask;

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