using UnityEngine;

namespace GD.Selection
{
    //BUG - NMCG - Is this working properly?
    public class SphereCastSelector : MonoBehaviour, ISelector
    {
        [SerializeField] private string selectableTag = "Selectable";
        [SerializeField] private LayerMask layerMask;
        [SerializeField] private float radius = 1;
        [SerializeField] private int maxDistance = 10;

        private Transform selection;
        private Ray ray;
        private RaycastHit hitInfo;

        public void Check(Ray ray)
        {
            selection = null;
            this.ray = ray;

            //    RaycastHit[] hitInfoArray = Physics.SphereCastAll(ray, radius);

            if (Physics.SphereCast(ray, radius, out hitInfo, maxDistance, layerMask.value))
            {
                var currentSelection = hitInfo.transform;
                if (currentSelection.CompareTag(selectableTag))
                    selection = currentSelection;
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(ray.origin, radius);
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