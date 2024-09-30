using GD.Selection;
using UnityEngine;

public class GameObjectRayProvider : MonoBehaviour, IRayProvider
{
    [SerializeField]
    private GameObject rayOrigin;

    private Ray ray;

    [SerializeField]
    private Color rayColor = Color.yellow;

    [SerializeField]
    private float rayLength = 10;

    public Ray CreateRay()
    {
        ray = new Ray(rayOrigin.transform.position,
            rayOrigin.transform.forward);
        return ray;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawLine(ray.origin,
            ray.origin + rayLength * ray.direction);
    }
}