using GD.Selection;
using Unity.Android.Types;
using UnityEngine;

public class GameObjectRayProvider : MonoBehaviour, IRayProvider
{
    [SerializeField]
    [Tooltip("Normally set to the in-game player game object")]
    private GameObject rayOrigin;

    [SerializeField]
    [Tooltip("Set ray length")]
    [Range(1, 100)]
    private float rayLength = 20;

    [SerializeField]
    [Tooltip("Set ray color (non HDR)")]
    private Color rayColor = Color.yellow;

    private Ray ray;

    public Ray CreateRay()
    {
        ray = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);
        return ray;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawLine(ray.origin,
            ray.origin + rayLength * ray.direction);
    }
}