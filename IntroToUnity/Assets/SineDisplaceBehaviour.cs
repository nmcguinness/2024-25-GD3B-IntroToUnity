using UnityEngine;

public class SineDisplaceBehaviour : MonoBehaviour
{
    #region Fields

    [SerializeField]
    [Tooltip("Transform of the object to be displaced")]
    private Transform target;

    [SerializeField]
    [Range(0f, 5f)]
    private float amplitude = 1;

    [SerializeField]
    private Vector3 direction = Vector3.up;

    private Vector3 originalPosition;

    #endregion Fields

    private void Start()
    {
        originalPosition = target.transform.localPosition;
    }

    private void Update()
    {
        var magnitude = amplitude * Mathf.Sin(Time.time);
        target.transform.localPosition = originalPosition + direction * magnitude;
    }
}